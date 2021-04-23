using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using AutoUpdaterDotNET;
using BrightIdeasSoftware;
using Sales_Manager.Properties;
using Microsoft.EntityFrameworkCore;

namespace Sales_Manager
{
    public partial class FormMain : Form
    {
        private readonly Timer _timer;

        private GetSales _loadingForm;

        #region Form Events

        public FormMain()
        {
            //#if DEBUG
            //    var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "RBSoft",
            //        "Sales Manager", "database.smdb");
            //    if (File.Exists(databasePath))
            //    {
            //        File.Delete(databasePath);
            //    }
            //#endif

            InitializeComponent();
            dateTimePickerFrom.Value = new DateTime(dateTimePickerTo.Value.Year, dateTimePickerTo.Value.Month, 1, 0, 0,
                0);
            dateTimePickerTo.Value = dateTimePickerTo.Value.AbsoluteEnd();
            dateTimePickerFrom.MaxDate = dateTimePickerTo.Value.AbsoluteStart();
            HelperMethods.FixFonts(this);
            WindowSettings.Restore(Settings.Default.WindowSettings, this);
            Application.CurrentCulture = new CultureInfo("en-US") {NumberFormat = {CurrencyNegativePattern = 1}};
            objectListViewTransactions.RestoreState(
                Convert.FromBase64String(Settings.Default.ObjectListViewTransactionsState));
            olvColumnDate.AspectGetter += delegate(object rowObject)
            {
                var transaction = rowObject as Transaction;
                return transaction?.Date.ToString("d", Application.CurrentCulture) ??
                       DateTime.Now.ToString("d", Application.CurrentCulture);
            };
            objectListViewTransactions.AboutToCreateGroups += ObjectListViewTransactionsOnAboutToCreateGroups;
            objectListViewTransactions.BeforeCreatingGroups +=
                (sender, args) =>
                {
                    args.Parameters.GroupComparer = args.Parameters.GroupByColumn.Equals(olvColumnDate)
                        ? new GroupDateComparer(args.Parameters.PrimarySortOrder)
                        : null;
                };
            thirtyMinutesToolStripMenuItem.Checked = Settings.Default.AutoRefreshInterval.Equals(30 * 60 * 1000);
            oneHourToolStripMenuItem.Checked = Settings.Default.AutoRefreshInterval.Equals(60 * 60 * 1000);
            twoHourToolStripMenuItem.Checked = Settings.Default.AutoRefreshInterval.Equals(2 * 60 * 60 * 1000);
            threeHourToolStripMenuItem.Checked = Settings.Default.AutoRefreshInterval.Equals(3 * 60 * 60 * 1000);
            fourHourToolStripMenuItem.Checked = Settings.Default.AutoRefreshInterval.Equals(4 * 60 * 60 * 1000);
            enableUpdateNotificationToolStripMenuItem.Checked = Settings.Default.EnableUpdateNotification;
            minimizeToTrayToolStripMenuItem.Checked = Settings.Default.MinimizeToTray;
            using (var db = new SalesManagerContext())
            {
                db.Database.EnsureCreated();
                if (!db.Countries.Any())
                {
                    var referral = new Country
                    {
                        ID = 1,
                        Name = "Referral",
                        Tax = 0
                    };
                    db.Countries.Add(referral);
                    db.SaveChanges();
                }
                if (!db.Products.Any())
                {
                    var all = new Product
                    {
                        ID = 1,
                        Name = "All",
                        BuyerFee = 0,
                        AuthorFee = 0,
                        Price = 0,
                        PartnerShare = 0,
                        Account = null
                    };
                    db.Products.Add(all);
                    var referral = new Product
                    {
                        ID = 2,
                        Name = "Referral",
                        BuyerFee = 0,
                        AuthorFee = 0,
                        Price = 0,
                        PartnerShare = 0,
                        Account = null
                    };
                    db.Products.Add(referral);
                    db.SaveChanges();
                }
                comboBoxProducts.DisplayMember = "Name";
                comboBoxAccounts.DisplayMember = "Name";
            }
            _timer = new Timer
            {
                Interval = Settings.Default.AutoRefreshInterval,
                Enabled = true
            };
            _timer.Tick += toolStripButtonUpdate_Click;
            _timer.Start();
            filterTextBox.Select();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            GetAccountsList();
            RefreshAccountsComboBox();
            GetCountriesList();
            GetProductsList();
            RefreshProductsComboBox();
            if (Settings.Default.EnableUpdateNotification)
            {
                AutoUpdater.Start("https://rbsoft.org/updates/sales-manager.xml");
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (Settings.Default.MinimizeToTray)
            {
                if (FormWindowState.Minimized == WindowState)
                {
                    notifyIcon.Visible = true;
                    Hide();
                }
                else
                {
                    notifyIcon.Visible = false;
                }
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.WindowSettings = WindowSettings.Record(Settings.Default.WindowSettings, this);
            byte[] objectListViewTransactionsState = objectListViewTransactions.SaveState();
            Settings.Default.ObjectListViewTransactionsState = Convert.ToBase64String(objectListViewTransactionsState);
            Settings.Default.Save();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == NativeMethods.WM_SHOWME)
            {
                ShowMe();
            }
            base.WndProc(ref m);
        }

        #endregion

        #region Methods

        private void ShowMe()
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Restore();
            }
            // get our current "TopMost" value (ours will always be false though)
            bool top = TopMost;
            // make our form jump to the top of everything
            TopMost = true;
            // set it back to whatever it was
            TopMost = top;
        }


        private void GetAccountsList()
        {
            objectListViewAccounts.ClearObjects();
            using (var db = new SalesManagerContext())
            {
                objectListViewAccounts.AddObjects(db.Accounts.ToList());
            }
        }

        private void GetCountriesList()
        {
            objectListViewCountries.ClearObjects();
            using (var db = new SalesManagerContext())
            {
                objectListViewCountries.AddObjects(db.Countries.Where(country => !country.ID.Equals(1)).ToList());
            }
        }

        private void GetProductsList()
        {
            objectListViewProducts.ClearObjects();
            using (var db = new SalesManagerContext())
            {
                var account = (Account) comboBoxAccounts.SelectedItem;
                IQueryable<Product> products = db.Products.Include(product => product.Account).Where(product => !product.ID.Equals(1) && !product.ID.Equals(2));
                if (account == null)
                {
                     products = products.Where(product => product.Account == null);
                }
                else
                {
                    products = products.Where(product => product.Account == null ||
                                                         product.Account.ID.Equals(account.ID));
                }
                objectListViewProducts.AddObjects(products.ToList());
            }
        }

        private void RefreshAccountsComboBox()
        {
            using (var db = new SalesManagerContext())
            {
                var accounts = db.Accounts.ToList();
                var selectedText = ((Account) comboBoxAccounts.SelectedItem)?.Name;
                comboBoxAccounts.DataSource = accounts;
                foreach (var item in comboBoxAccounts.Items)
                {
                    Account account = item as Account;
                    if (account != null && account.Name.Equals(selectedText))
                    {
                        comboBoxAccounts.SelectedItem = item;
                    }
                }
                if (accounts.Count.Equals(0))
                {
                    AddNewAccount();
                }
            }
        }

        private void RefreshProductsComboBox()
        {
            using (var db = new SalesManagerContext())
            {
                var selectedText = ((Product) comboBoxProducts.SelectedItem)?.Name;
                IQueryable<Product> products;
                var account = (Account)comboBoxAccounts.SelectedItem;
                if (account != null)
                {
                    products = db.Products.Include(product => product.Account).Where(product => product.Account == null ||
                                                         product.Account.ID.Equals(account.ID));
                }
                else
                {
                    products = db.Products.Include(product => product.Account).Where(product => product.Account == null);
                }
                comboBoxProducts.DataSource = products.ToList();
                foreach (var item in comboBoxProducts.Items)
                {
                    Product product = item as Product;
                    if (product != null && product.Name.Equals(selectedText))
                    {
                        comboBoxProducts.SelectedItem = item;
                    }
                }
            }
        }

        private void AddNewAccount()
        {
            var addAccount = new AddAccount();
            if (addAccount.ShowDialog().Equals(DialogResult.OK))
            {
                GetAccountsList();
                RefreshAccountsComboBox();
                GetProductsList();
                RefreshProductsComboBox();
            }
        }

        private void Restore()
        {
            Show();
            NativeMethods.ShowWindow(Handle, NativeMethods.SW_RESTORE);
            if(_loadingForm != null)
            {
                _loadingForm.WindowState = FormWindowState.Normal;
            }
        }

        private void PrepareChart()
        {
            if (tabControl.SelectedTab.Equals(tabPageGraph))
            {
                chart.ResetAutoValues();
                chart.Series.Clear();
                var dateTimeFormatInfo = new DateTimeFormatInfo();

                using (var db = new SalesManagerContext())
                {
                    var shareSeries = new Series { Name = "Partner Share" };
                    var incomeSeries = new Series { Name = "Income" };
                    var product = (Product)comboBoxProducts.SelectedItem;
                    for (int i = 1; i <= 12; i++)
                    {
                        var transactions = db.Transactions.Include(transaction => transaction.Product).Include(transaction => transaction.Account)
                            .Where(
                                transaction =>
                                    transaction.Date.Month.Equals(i) &&
                                    transaction.Date.Year.Equals(dateTimePickerTo.Value.Year) && transaction.Account.ID.Equals(((Account)comboBoxAccounts.SelectedItem).ID));

                        if (!product.ID.Equals(1))
                        {
                            transactions = transactions
                                .Where(
                                    transaction =>
                                        transaction.Product.ID.Equals(product.ID));
                        }
                        double partnerShare = transactions.Sum(transaction => transaction.PartnerShare);
                        shareSeries.Points.AddXY(dateTimeFormatInfo.GetMonthName(i), partnerShare);
                        double receivedAmount =
                            transactions.Sum(transaction => transaction.ReceivedAmount + transaction.SupportAmount);
                        incomeSeries.Points.AddXY(dateTimeFormatInfo.GetMonthName(i), receivedAmount);
                    }
                    chart.Series.Add(shareSeries);
                    chart.Series.Add(incomeSeries);
                }
            }
        }

        #endregion

        #region ObjectListView Events

        private void ObjectListViewTransactionsOnAboutToCreateGroups(object sender,
            CreateGroupsEventArgs createGroupsEventArgs)
        {
            foreach (var olvGroup in createGroupsEventArgs.Groups)
            {
                var total = 0.0;
                var partnerShare = 0.0;
                var tax = 0.0;
                foreach (var transaction in olvGroup.Items.Select(olvListItem => olvListItem.RowObject as Transaction))
                {
                    total = total + transaction.ReceivedAmount + transaction.SupportAmount;
                    tax = tax + transaction.Tax;
                    partnerShare = partnerShare + transaction.PartnerShare;
                }
                olvGroup.Header +=
                    $"[Income : {total:C2}][Partner Share : {partnerShare:C2}][Tax : {tax:C2}][Total : {total + partnerShare:C2}]";
            }
        }

        private void objectListViewTransactions_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            objectListViewTransactions_SelectedIndexChanged(sender, null);
        }

        private void objectListViewTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            editTransactionToolStripMenuItem.Enabled = toolStripButtonEdit.Enabled =
                objectListViewTransactions.SelectedObject != null;
            removeTransactionToolStripMenuItem.Enabled = toolStripButtonRemove.Enabled =
                    objectListViewTransactions.SelectedObjects.Count > 0;
        }

        private void objectListViewCountries_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            objectListViewCountries_SelectedIndexChanged(sender, null);
        }

        private void objectListViewCountries_SelectedIndexChanged(object sender, EventArgs e)
        {
            editCountryToolStripMenuItem.Enabled = toolStripButtonEdit.Enabled =
                removeCountryToolStripMenuItem.Enabled = toolStripButtonRemove.Enabled =
                    objectListViewCountries.SelectedObject != null;
        }

        private void objectListViewProducts_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            objectListViewProducts_SelectedIndexChanged(sender, null);
        }

        private void objectListViewProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            editProductToolStripMenuItem.Enabled = toolStripButtonEdit.Enabled =
                removeProductToolStripMenuItem.Enabled = toolStripButtonRemove.Enabled =
                    objectListViewProducts.SelectedObject != null;
        }

        private void objectListViewAccounts_ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            objectListViewAccounts_SelectedIndexChanged(sender, null);
        }

        private void objectListViewAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            editAccountToolStripMenuItem.Enabled = toolStripButtonEdit.Enabled =
                removeAccountToolStripMenuItem.Enabled = toolStripButtonRemove.Enabled =
                    objectListViewAccounts.SelectedObject != null;
        }

        private void objectListViewTransactions_BeforeSorting(object sender, BeforeSortingEventArgs e)
        {
            // Set the ListViewItemSorter property to a new ListViewItemComparer object.  
            objectListViewTransactions.CustomSorter +=
                (column, order) =>
                {
                    objectListViewTransactions.ListViewItemSorter = column.Equals(olvColumnDate)
                        ? new ListViewItemComparer(e.SortOrder)
                        : null;
                };
        }

        #endregion

        #region ContextMenu Events

        private void editTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewTransactions.SelectedObject != null)
            {
                var transaction = (Transaction)objectListViewTransactions.SelectedObject;
                var account = (Account)comboBoxAccounts.SelectedItem;
                var editTransaction = new AddTransaction(account, transaction);
                if (!transaction.Product.ID.Equals(2))
                {
                    if (editTransaction.ShowDialog().Equals(DialogResult.OK))
                    {
                        dateTimePicker_ValueChanged(sender, e);
                    }
                }
            }
        }

        private void removeTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewTransactions.SelectedObjects.Count > 0)
            {
                var dialogResult =
                    MessageBox.Show(
                        objectListViewTransactions.SelectedObjects.Count > 1
                            ? Resources.confirmationRemoveTransactionsMessage
                            : Resources.confirmationRemoveTransactionMessage, Resources.confirmationCaption,
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    foreach (var transactionObject in objectListViewTransactions.SelectedObjects)
                    {
                        var transaction = (Transaction)transactionObject;
                        transaction.Remove();
                    }
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
        }

        private void editCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewCountries.SelectedObject != null)
            {
                var country = (Country)objectListViewCountries.SelectedObject;
                var editCountry = new AddCountry(country);
                if (editCountry.ShowDialog() == DialogResult.OK)
                {
                    objectListViewCountries.RefreshObject(country);
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
        }

        private void removeCountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewCountries.SelectedObject != null)
            {
                var dialogResult =
                    MessageBox.Show(
                        Resources.confirmationRemoveCountryMessage,
                        Resources.confirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    var country = objectListViewCountries.SelectedObject as Country;
                    country?.Remove();
                    objectListViewCountries.RemoveObject(country);
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
        }

        private void editProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewProducts.SelectedObject != null)
            {
                var product = (Product)objectListViewProducts.SelectedObject;
                var account = (Account)comboBoxAccounts.SelectedItem;
                var editProduct = new AddProduct(account, product);
                if (editProduct.ShowDialog() == DialogResult.OK)
                {
                    objectListViewProducts.RefreshObject(product);
                    RefreshProductsComboBox();
                }
            }
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewProducts.SelectedObject != null)
            {
                var dialogResult =
                    MessageBox.Show(
                        Resources.confirmationRemoveProductMessage,
                        Resources.confirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    var product = objectListViewProducts.SelectedObject as Product;
                    product?.Remove();
                    objectListViewProducts.RemoveObject(product);
                    RefreshProductsComboBox();
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
        }

        private void editAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewAccounts != null)
            {
                var account = (Account)objectListViewAccounts.SelectedObject;
                var editAccount = new AddAccount(account);
                if (editAccount.ShowDialog() == DialogResult.OK)
                {
                    objectListViewAccounts.RefreshObject(account);
                    RefreshAccountsComboBox();
                    RefreshProductsComboBox();
                    GetProductsList();
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
        }

        private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objectListViewAccounts.SelectedObject != null)
            {
                var dialogResult =
                    MessageBox.Show(
                        Resources.confirmationRemoveAccountMessage,
                        Resources.confirmationCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult.Equals(DialogResult.Yes))
                {
                    var account = objectListViewAccounts.SelectedObject as Account;
                    account?.Remove();
                    objectListViewAccounts.RemoveObject(account);
                    RefreshAccountsComboBox();
                    RefreshProductsComboBox();
                    GetProductsList();
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restore();
        }

        #endregion

        #region ToolStrip Button Events

        private void toolStripButtonAdd_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Equals(tabPageTransactions))
            {
                var account = (Account)comboBoxAccounts.SelectedItem;
                var addTransaction = new AddTransaction(account);
                if (addTransaction.ShowDialog() == DialogResult.OK)
                {
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
            else if (tabControl.SelectedTab.Equals(tabPageCountries))
            {
                var addCountry = new AddCountry();
                if (addCountry.ShowDialog() == DialogResult.OK)
                {
                    GetCountriesList();
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
            else if (tabControl.SelectedTab.Equals(tabPageProducts))
            {
                var account = (Account)comboBoxAccounts.SelectedItem;
                var addProduct = new AddProduct(account);
                if (addProduct.ShowDialog() == DialogResult.OK)
                {
                    RefreshProductsComboBox();
                    GetProductsList();
                    dateTimePicker_ValueChanged(sender, e);
                }
            }
            else if (tabControl.SelectedTab.Equals(tabPageAccounts))
            {
                AddNewAccount();
                dateTimePicker_ValueChanged(sender, e);
            }
        }

        private void toolStripButtonEdit_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Equals(tabPageTransactions))
            {
                editTransactionToolStripMenuItem_Click(sender, e);
            }
            else if (tabControl.SelectedTab.Equals(tabPageCountries))
            {
                editCountryToolStripMenuItem_Click(sender, e);
            }
            else if (tabControl.SelectedTab.Equals(tabPageProducts))
            {
                editProductToolStripMenuItem_Click(sender, e);
            }
            else if (tabControl.SelectedTab.Equals(tabPageAccounts))
            {
                editAccountToolStripMenuItem_Click(sender, e);
            }
        }

        private void toolStripButtonRemove_Click(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Equals(tabPageTransactions))
            {
                removeTransactionToolStripMenuItem_Click(sender, e);
            }
            else if (tabControl.SelectedTab.Equals(tabPageCountries))
            {
                removeCountryToolStripMenuItem_Click(sender, e);
            }
            else if (tabControl.SelectedTab.Equals(tabPageProducts))
            {
                removeProductToolStripMenuItem_Click(sender, e);
            }
            else if (tabControl.SelectedTab.Equals(tabPageAccounts))
            {
                removeAccountToolStripMenuItem_Click(sender, e);
            }
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            if (_loadingForm == null)
            {
                var totalTransactions = objectListViewTransactions.Items.Count;
                _loadingForm = new GetSales(dateTimePickerFrom.Value, dateTimePickerTo.Value,
                    (Account)comboBoxAccounts.SelectedItem, WindowState == FormWindowState.Minimized);
                if (_loadingForm.ShowDialog(this).Equals(DialogResult.OK))
                {
                    toolStripButtonEdit.Enabled = false;
                    toolStripButtonRemove.Enabled = false;
                    dateTimePicker_ValueChanged(sender, e);
                    GetCountriesList();
                    GetProductsList();
                    RefreshProductsComboBox();
                    var newTransactions = objectListViewTransactions.Items.Count - totalTransactions;
                    if (notifyIcon.Visible && newTransactions > 0)
                    {
                        notifyIcon.ShowBalloonTip(5, "New Transactions", $"There are {newTransactions} new transactions since you last updated.", ToolTipIcon.Info);
                    }
                }
                else
                {
                    if (WindowState != FormWindowState.Minimized)
                    {
                        MessageBox.Show(Resources.noInternetErrorMsg, Resources.noInternetErrorCaption,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                _loadingForm = null;
            }
        }

        private void toolStripButtonExport_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                HelperMethods.ListViewToCSV(objectListViewTransactions, saveFileDialog.FileName, false);

                //OLVExporter olvExporter = new OLVExporter(objectListViewTransactions)
                //var csv = olvExporter.ExportTo(OLVExporter.ExportFormat.CSV);
                //File.WriteAllText(saveFileDialog.FileName, csv);
            }
        }

        #endregion

        #region Other Events

        private void filterTextBox_TextChanged(object sender, EventArgs e)
        {
            objectListViewTransactions.ModelFilter = TextMatchFilter.Contains(objectListViewTransactions,
                filterTextBox.Text);

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (sender.Equals(dateTimePickerTo))
            {
                if (!dateTimePickerTo.Value.Equals(dateTimePickerTo.Value.AbsoluteEnd()))
                {
                    dateTimePickerFrom.MaxDate = dateTimePickerTo.Value.AbsoluteStart();
                    dateTimePickerTo.Value = dateTimePickerTo.Value.AbsoluteEnd();
                    return;
                }
            }
            if (sender.Equals(dateTimePickerFrom))
            {
                if (!dateTimePickerFrom.Value.Equals(dateTimePickerFrom.Value.AbsoluteStart()))
                {
                    dateTimePickerFrom.Value = dateTimePickerFrom.Value.AbsoluteStart();
                    return;
                }
            }
            if (dateTimePickerTo.Value.Equals(dateTimePickerTo.Value.AbsoluteEnd()) &&
                dateTimePickerFrom.Value.Equals(dateTimePickerFrom.Value.AbsoluteStart()))
            {
                if (comboBoxProducts.Items.Count > 0)
                {
                    using (var db = new SalesManagerContext())
                    {
                        objectListViewTransactions.ClearObjects();
                        var account = (Account) comboBoxAccounts.SelectedItem;
                        IQueryable<Transaction> transactions =
                            db.Transactions.Include(transaction => transaction.Country)
                                .Include(transaction => transaction.Product)
                                .Include(transaction => transaction.Account)
                                .Where(
                                    transaction =>
                                        transaction.Date.Ticks > dateTimePickerFrom.Value.Ticks &&
                                        transaction.Date.Ticks < dateTimePickerTo.Value.Ticks);
                        if (account != null)
                        {
                            transactions = transactions.Where(transaction => transaction.Account.ID.Equals(account.ID));
                        }
                        if (!((Product)comboBoxProducts.SelectedItem).ID.Equals(1))
                        {
                            transactions = transactions
                                .Where(
                                    transaction =>
                                        transaction.Product.ID.Equals(((Product)comboBoxProducts.SelectedItem).ID));
                        }
                        objectListViewTransactions.AddObjects(transactions.ToList());
                        labelIncome.Text =
                            $@"{
                                transactions.Select(transaction => transaction.ReceivedAmount).Sum() + transactions
                                    .Select(transaction => transaction.SupportAmount)
                                    .Sum():C2}";
                        labelPartnerShare.Text =
                            $@"{transactions.Select(transaction => transaction.PartnerShare).Sum():C2}";
                        labelTotal.Text =
                        (double.Parse(labelIncome.Text, NumberStyles.Currency) +
                         double.Parse(labelPartnerShare.Text, NumberStyles.Currency)).ToString("C2");
                        var cancelledTransactions = new Dictionary<string, Transaction>();
                        foreach (var transaction in transactions.ToList())
                        {
                            if (transaction.ReceivedAmount < 0 && !cancelledTransactions.ContainsKey(transaction.OrderID + transaction.Product.ID))
                            {
                                cancelledTransactions.Add(transaction.OrderID + transaction.Product.ID, transaction);
                            }
                        }
                        int count = 0;
                        foreach (var transaction in transactions)
                        {
                            if (transaction.ReceivedAmount > 0 && !transaction.Product.ID.Equals(2))
                            {
                                if (cancelledTransactions.ContainsKey(transaction.OrderID + transaction.Product.ID))
                                {
                                    cancelledTransactions.Remove(transaction.OrderID + transaction.Product.ID);
                                    continue;
                                }
                                count++;
                            }
                        }
                        labelTotalSales.Text = count.ToString();
                        if (sender.Equals(comboBoxAccounts))
                        {
                            RefreshProductsComboBox();
                            GetProductsList();
                        }
                    }
                    PrepareChart();
                }
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripButtonAdd.Enabled = !tabControl.SelectedTab.Equals(tabPageGraph);
            toolStripButtonEdit.Enabled = toolStripButtonRemove.Enabled = false;
            PrepareChart();
        }

        private void chart_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Check selected chart element and set tooltip text for it
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = $"{dataPoint.YValues[0]:C2}";
                    break;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Left))
            {
                Restore();
            }
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            Restore();
        }

        #endregion

        #region Menu Events

        private void supportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/ravibpatel/SalesManager/issues");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();
            about.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "Help.chm");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Equals(thirtyMinutesToolStripMenuItem))
            {
                Settings.Default.AutoRefreshInterval = 30 * 60 * 1000;
            }
            else if (e.ClickedItem.Equals(oneHourToolStripMenuItem))
            {
                Settings.Default.AutoRefreshInterval = 60 * 60 * 1000;
            }
            else if (e.ClickedItem.Equals(twoHourToolStripMenuItem))
            {
                Settings.Default.AutoRefreshInterval = 2 * 60 * 60 * 1000;
            }
            else if (e.ClickedItem.Equals(threeHourToolStripMenuItem))
            {
                Settings.Default.AutoRefreshInterval = 3 * 60 * 60 * 1000;
            }
            else if (e.ClickedItem.Equals(fourHourToolStripMenuItem))
            {
                Settings.Default.AutoRefreshInterval = 4 * 60 * 60 * 1000;
            }
            Settings.Default.Save();
            _timer.Stop();
            _timer.Interval = Settings.Default.AutoRefreshInterval;
            _timer.Start();
            foreach (var dropDownItem in autoRefreshToolStripMenuItem.DropDownItems)
            {
                ((ToolStripMenuItem)dropDownItem).Checked = dropDownItem.Equals(e.ClickedItem);
            }
        }

        private void minimizeToTrayToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.MinimizeToTray = minimizeToTrayToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        private void enableUpdateNotificationToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.EnableUpdateNotification = enableUpdateNotificationToolStripMenuItem.Checked;
            Settings.Default.Save();
        }

        #endregion
    }


    class ListViewItemComparer : IComparer
    {
        private readonly SortOrder _sortOrder;

        public ListViewItemComparer(SortOrder order)
        {
            _sortOrder = order;
        }

        public int Compare(object x, object y)
        {
            // Determine whether the type being compared is a date type.
            // Parse the two objects passed as a parameter as a DateTime.  
            DateTime firstDate = ((Transaction) ((OLVListItem) x).RowObject).Date.Date;
            DateTime secondDate = ((Transaction) ((OLVListItem) y).RowObject).Date.Date;
            // Compare the two dates.  
            var returnVal = DateTime.Compare(firstDate, secondDate);

            // Determine whether the sort order is descending.  
            if (_sortOrder == SortOrder.Descending)
                // Invert the value returned by String.Compare.  
                returnVal *= -1;
            return returnVal;
        }
    }

    class GroupDateComparer : IComparer<OLVGroup>
    {
        private readonly SortOrder _sortOrder;

        public GroupDateComparer(SortOrder sortOrder)
        {
            _sortOrder = sortOrder;
        }

        public int Compare(OLVGroup x, OLVGroup y)
        {
            var firstDateTime = ((Transaction) x.Items[0].RowObject).Date.Date;
            var secondDateTime = ((Transaction) y.Items[0].RowObject).Date.Date;
            var returnVal = DateTime.Compare(firstDateTime, secondDateTime);

            if (_sortOrder == SortOrder.Descending)
                returnVal *= -1;
            return returnVal;
        }
    }
}