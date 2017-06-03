namespace Sales_Manager
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.contextMenuStripTransaction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripCountry = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCountryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.pictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.groupBoxAccount = new System.Windows.Forms.GroupBox();
            this.comboBoxAccounts = new System.Windows.Forms.ComboBox();
            this.groupBoxTotalSales = new System.Windows.Forms.GroupBox();
            this.labelTotalSales = new System.Windows.Forms.Label();
            this.groupBoxTotal = new System.Windows.Forms.GroupBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBoxPartnerShare = new System.Windows.Forms.GroupBox();
            this.labelPartnerShare = new System.Windows.Forms.Label();
            this.groupBoxIncome = new System.Windows.Forms.GroupBox();
            this.labelIncome = new System.Windows.Forms.Label();
            this.groupBoxMonthYear = new System.Windows.Forms.GroupBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.groupBoxProducts = new System.Windows.Forms.GroupBox();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageTransactions = new System.Windows.Forms.TabPage();
            this.objectListViewTransactions = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnOrderID = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCountry = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDate = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnSupportAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnReceivedAmount = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPartnerShare = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPartnerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnTax = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAuthorFee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnBuyerFee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnDetail = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageCountries = new System.Windows.Forms.TabPage();
            this.objectListViewCountries = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnCountryName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnCountryTax = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageProducts = new System.Windows.Forms.TabPage();
            this.objectListViewProducts = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnProductName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProductPrice = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProductAuthorFee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProductBuyerFee = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProductPartnerShare = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnProductPartnerName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageAccounts = new System.Windows.Forms.TabPage();
            this.objectListViewAccounts = new BrightIdeasSoftware.ObjectListView();
            this.olvColumnAccountName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumnAccountAPIKey = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemove = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExport = new System.Windows.Forms.ToolStripButton();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirtyMinutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oneHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threeHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourHourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableUpdateNotificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripTransaction.SuspendLayout();
            this.contextMenuStripCountry.SuspendLayout();
            this.contextMenuStripProduct.SuspendLayout();
            this.contextMenuStripAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).BeginInit();
            this.groupBoxAccount.SuspendLayout();
            this.groupBoxTotalSales.SuspendLayout();
            this.groupBoxTotal.SuspendLayout();
            this.groupBoxPartnerShare.SuspendLayout();
            this.groupBoxIncome.SuspendLayout();
            this.groupBoxMonthYear.SuspendLayout();
            this.groupBoxProducts.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageTransactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTransactions)).BeginInit();
            this.tabPageCountries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCountries)).BeginInit();
            this.tabPageProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewProducts)).BeginInit();
            this.tabPageAccounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewAccounts)).BeginInit();
            this.tabPageGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.contextMenuStripNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // contextMenuStripTransaction
            // 
            this.contextMenuStripTransaction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTransactionToolStripMenuItem,
            this.removeTransactionToolStripMenuItem});
            this.contextMenuStripTransaction.Name = "contextMenuStripTransaction";
            this.contextMenuStripTransaction.Size = new System.Drawing.Size(118, 48);
            // 
            // editTransactionToolStripMenuItem
            // 
            this.editTransactionToolStripMenuItem.Enabled = false;
            this.editTransactionToolStripMenuItem.Name = "editTransactionToolStripMenuItem";
            this.editTransactionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editTransactionToolStripMenuItem.Text = "Edit";
            this.editTransactionToolStripMenuItem.Click += new System.EventHandler(this.editTransactionToolStripMenuItem_Click);
            // 
            // removeTransactionToolStripMenuItem
            // 
            this.removeTransactionToolStripMenuItem.Enabled = false;
            this.removeTransactionToolStripMenuItem.Name = "removeTransactionToolStripMenuItem";
            this.removeTransactionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeTransactionToolStripMenuItem.Text = "Remove";
            this.removeTransactionToolStripMenuItem.Click += new System.EventHandler(this.removeTransactionToolStripMenuItem_Click);
            // 
            // contextMenuStripCountry
            // 
            this.contextMenuStripCountry.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editCountryToolStripMenuItem,
            this.removeCountryToolStripMenuItem});
            this.contextMenuStripCountry.Name = "contextMenuStripCountry";
            this.contextMenuStripCountry.Size = new System.Drawing.Size(118, 48);
            // 
            // editCountryToolStripMenuItem
            // 
            this.editCountryToolStripMenuItem.Enabled = false;
            this.editCountryToolStripMenuItem.Name = "editCountryToolStripMenuItem";
            this.editCountryToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editCountryToolStripMenuItem.Text = "Edit";
            this.editCountryToolStripMenuItem.Click += new System.EventHandler(this.editCountryToolStripMenuItem_Click);
            // 
            // removeCountryToolStripMenuItem
            // 
            this.removeCountryToolStripMenuItem.Enabled = false;
            this.removeCountryToolStripMenuItem.Name = "removeCountryToolStripMenuItem";
            this.removeCountryToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeCountryToolStripMenuItem.Text = "Remove";
            this.removeCountryToolStripMenuItem.Click += new System.EventHandler(this.removeCountryToolStripMenuItem_Click);
            // 
            // contextMenuStripProduct
            // 
            this.contextMenuStripProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editProductToolStripMenuItem,
            this.removeProductToolStripMenuItem});
            this.contextMenuStripProduct.Name = "contextMenuStripProduct";
            this.contextMenuStripProduct.Size = new System.Drawing.Size(118, 48);
            // 
            // editProductToolStripMenuItem
            // 
            this.editProductToolStripMenuItem.Enabled = false;
            this.editProductToolStripMenuItem.Name = "editProductToolStripMenuItem";
            this.editProductToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editProductToolStripMenuItem.Text = "Edit";
            this.editProductToolStripMenuItem.Click += new System.EventHandler(this.editProductToolStripMenuItem_Click);
            // 
            // removeProductToolStripMenuItem
            // 
            this.removeProductToolStripMenuItem.Enabled = false;
            this.removeProductToolStripMenuItem.Name = "removeProductToolStripMenuItem";
            this.removeProductToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeProductToolStripMenuItem.Text = "Remove";
            this.removeProductToolStripMenuItem.Click += new System.EventHandler(this.removeProductToolStripMenuItem_Click);
            // 
            // contextMenuStripAccount
            // 
            this.contextMenuStripAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAccountToolStripMenuItem,
            this.removeAccountToolStripMenuItem});
            this.contextMenuStripAccount.Name = "contextMenuStripAccounts";
            this.contextMenuStripAccount.Size = new System.Drawing.Size(118, 48);
            // 
            // editAccountToolStripMenuItem
            // 
            this.editAccountToolStripMenuItem.Enabled = false;
            this.editAccountToolStripMenuItem.Name = "editAccountToolStripMenuItem";
            this.editAccountToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editAccountToolStripMenuItem.Text = "Edit";
            this.editAccountToolStripMenuItem.Click += new System.EventHandler(this.editAccountToolStripMenuItem_Click);
            // 
            // removeAccountToolStripMenuItem
            // 
            this.removeAccountToolStripMenuItem.Enabled = false;
            this.removeAccountToolStripMenuItem.Name = "removeAccountToolStripMenuItem";
            this.removeAccountToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeAccountToolStripMenuItem.Text = "Remove";
            this.removeAccountToolStripMenuItem.Click += new System.EventHandler(this.removeAccountToolStripMenuItem_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.pictureBoxDonate);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxAccount);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxTotalSales);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxTotal);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxPartnerShare);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxIncome);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxMonthYear);
            this.splitContainer.Panel1.Controls.Add(this.groupBoxProducts);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tabControl);
            this.splitContainer.Size = new System.Drawing.Size(1127, 562);
            this.splitContainer.SplitterDistance = 212;
            this.splitContainer.TabIndex = 1;
            // 
            // pictureBoxDonate
            // 
            this.pictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate.Image = global::Sales_Manager.Properties.Resources.PayPal_Donate;
            this.pictureBoxDonate.Location = new System.Drawing.Point(12, 464);
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.Size = new System.Drawing.Size(160, 75);
            this.pictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxDonate.TabIndex = 21;
            this.pictureBoxDonate.TabStop = false;
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // groupBoxAccount
            // 
            this.groupBoxAccount.Controls.Add(this.comboBoxAccounts);
            this.groupBoxAccount.Location = new System.Drawing.Point(12, 143);
            this.groupBoxAccount.Name = "groupBoxAccount";
            this.groupBoxAccount.Size = new System.Drawing.Size(160, 50);
            this.groupBoxAccount.TabIndex = 20;
            this.groupBoxAccount.TabStop = false;
            this.groupBoxAccount.Text = "Account";
            // 
            // comboBoxAccounts
            // 
            this.comboBoxAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAccounts.FormattingEnabled = true;
            this.comboBoxAccounts.Location = new System.Drawing.Point(6, 19);
            this.comboBoxAccounts.Name = "comboBoxAccounts";
            this.comboBoxAccounts.Size = new System.Drawing.Size(148, 21);
            this.comboBoxAccounts.TabIndex = 0;
            this.comboBoxAccounts.SelectionChangeCommitted += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // groupBoxTotalSales
            // 
            this.groupBoxTotalSales.Controls.Add(this.labelTotalSales);
            this.groupBoxTotalSales.Location = new System.Drawing.Point(12, 397);
            this.groupBoxTotalSales.Name = "groupBoxTotalSales";
            this.groupBoxTotalSales.Size = new System.Drawing.Size(160, 60);
            this.groupBoxTotalSales.TabIndex = 19;
            this.groupBoxTotalSales.TabStop = false;
            this.groupBoxTotalSales.Text = "Total Sales";
            // 
            // labelTotalSales
            // 
            this.labelTotalSales.AutoSize = true;
            this.labelTotalSales.Location = new System.Drawing.Point(6, 25);
            this.labelTotalSales.Name = "labelTotalSales";
            this.labelTotalSales.Size = new System.Drawing.Size(19, 13);
            this.labelTotalSales.TabIndex = 0;
            this.labelTotalSales.Text = "$0";
            // 
            // groupBoxTotal
            // 
            this.groupBoxTotal.Controls.Add(this.labelTotal);
            this.groupBoxTotal.Location = new System.Drawing.Point(12, 331);
            this.groupBoxTotal.Name = "groupBoxTotal";
            this.groupBoxTotal.Size = new System.Drawing.Size(160, 60);
            this.groupBoxTotal.TabIndex = 18;
            this.groupBoxTotal.TabStop = false;
            this.groupBoxTotal.Text = "Total";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(6, 25);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "$0.00";
            // 
            // groupBoxPartnerShare
            // 
            this.groupBoxPartnerShare.Controls.Add(this.labelPartnerShare);
            this.groupBoxPartnerShare.Location = new System.Drawing.Point(12, 265);
            this.groupBoxPartnerShare.Name = "groupBoxPartnerShare";
            this.groupBoxPartnerShare.Size = new System.Drawing.Size(160, 60);
            this.groupBoxPartnerShare.TabIndex = 17;
            this.groupBoxPartnerShare.TabStop = false;
            this.groupBoxPartnerShare.Text = "Partner Share";
            // 
            // labelPartnerShare
            // 
            this.labelPartnerShare.AutoSize = true;
            this.labelPartnerShare.Location = new System.Drawing.Point(6, 25);
            this.labelPartnerShare.Name = "labelPartnerShare";
            this.labelPartnerShare.Size = new System.Drawing.Size(34, 13);
            this.labelPartnerShare.TabIndex = 0;
            this.labelPartnerShare.Text = "$0.00";
            // 
            // groupBoxIncome
            // 
            this.groupBoxIncome.Controls.Add(this.labelIncome);
            this.groupBoxIncome.Location = new System.Drawing.Point(12, 199);
            this.groupBoxIncome.Name = "groupBoxIncome";
            this.groupBoxIncome.Size = new System.Drawing.Size(160, 60);
            this.groupBoxIncome.TabIndex = 16;
            this.groupBoxIncome.TabStop = false;
            this.groupBoxIncome.Text = "Income";
            // 
            // labelIncome
            // 
            this.labelIncome.AutoSize = true;
            this.labelIncome.Location = new System.Drawing.Point(6, 26);
            this.labelIncome.Name = "labelIncome";
            this.labelIncome.Size = new System.Drawing.Size(34, 13);
            this.labelIncome.TabIndex = 0;
            this.labelIncome.Text = "$0.00";
            // 
            // groupBoxMonthYear
            // 
            this.groupBoxMonthYear.Controls.Add(this.dateTimePickerFrom);
            this.groupBoxMonthYear.Controls.Add(this.dateTimePickerTo);
            this.groupBoxMonthYear.Location = new System.Drawing.Point(12, 7);
            this.groupBoxMonthYear.Name = "groupBoxMonthYear";
            this.groupBoxMonthYear.Size = new System.Drawing.Size(160, 74);
            this.groupBoxMonthYear.TabIndex = 15;
            this.groupBoxMonthYear.TabStop = false;
            this.groupBoxMonthYear.Text = "Time";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerFrom.Location = new System.Drawing.Point(6, 19);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerFrom.TabIndex = 1;
            this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTo.Location = new System.Drawing.Point(6, 48);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(148, 20);
            this.dateTimePickerTo.TabIndex = 0;
            this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // groupBoxProducts
            // 
            this.groupBoxProducts.Controls.Add(this.comboBoxProducts);
            this.groupBoxProducts.Location = new System.Drawing.Point(12, 87);
            this.groupBoxProducts.Name = "groupBoxProducts";
            this.groupBoxProducts.Size = new System.Drawing.Size(160, 50);
            this.groupBoxProducts.TabIndex = 0;
            this.groupBoxProducts.TabStop = false;
            this.groupBoxProducts.Text = "Product";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(6, 19);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(148, 21);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageTransactions);
            this.tabControl.Controls.Add(this.tabPageCountries);
            this.tabControl.Controls.Add(this.tabPageProducts);
            this.tabControl.Controls.Add(this.tabPageAccounts);
            this.tabControl.Controls.Add(this.tabPageGraph);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(911, 562);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageTransactions
            // 
            this.tabPageTransactions.Controls.Add(this.objectListViewTransactions);
            this.tabPageTransactions.Location = new System.Drawing.Point(4, 22);
            this.tabPageTransactions.Name = "tabPageTransactions";
            this.tabPageTransactions.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTransactions.Size = new System.Drawing.Size(903, 536);
            this.tabPageTransactions.TabIndex = 0;
            this.tabPageTransactions.Text = "Transactions";
            this.tabPageTransactions.UseVisualStyleBackColor = true;
            // 
            // objectListViewTransactions
            // 
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnName);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnOrderID);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnCountry);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnDate);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnSupportAmount);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnReceivedAmount);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnPartnerShare);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnPartnerName);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnTax);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnPrice);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnAuthorFee);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnBuyerFee);
            this.objectListViewTransactions.AllColumns.Add(this.olvColumnDetail);
            this.objectListViewTransactions.AllowColumnReorder = true;
            this.objectListViewTransactions.CellEditUseWholeCell = false;
            this.objectListViewTransactions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnName,
            this.olvColumnOrderID,
            this.olvColumnCountry,
            this.olvColumnDate,
            this.olvColumnSupportAmount,
            this.olvColumnReceivedAmount,
            this.olvColumnPartnerShare,
            this.olvColumnPartnerName,
            this.olvColumnTax,
            this.olvColumnPrice,
            this.olvColumnAuthorFee,
            this.olvColumnBuyerFee,
            this.olvColumnDetail});
            this.objectListViewTransactions.ContextMenuStrip = this.contextMenuStripTransaction;
            this.objectListViewTransactions.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewTransactions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewTransactions.FullRowSelect = true;
            this.objectListViewTransactions.Location = new System.Drawing.Point(3, 3);
            this.objectListViewTransactions.Name = "objectListViewTransactions";
            this.objectListViewTransactions.ShowCommandMenuOnRightClick = true;
            this.objectListViewTransactions.ShowItemCountOnGroups = true;
            this.objectListViewTransactions.Size = new System.Drawing.Size(897, 530);
            this.objectListViewTransactions.TabIndex = 0;
            this.objectListViewTransactions.UseCompatibleStateImageBehavior = false;
            this.objectListViewTransactions.UseFilterIndicator = true;
            this.objectListViewTransactions.UseFiltering = true;
            this.objectListViewTransactions.View = System.Windows.Forms.View.Details;
            this.objectListViewTransactions.BeforeSorting += new System.EventHandler<BrightIdeasSoftware.BeforeSortingEventArgs>(this.objectListViewTransactions_BeforeSorting);
            this.objectListViewTransactions.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListViewTransactions_ItemsChanged);
            this.objectListViewTransactions.SelectedIndexChanged += new System.EventHandler(this.objectListViewTransactions_SelectedIndexChanged);
            // 
            // olvColumnName
            // 
            this.olvColumnName.AspectName = "Product.Name";
            this.olvColumnName.Text = "Product";
            this.olvColumnName.Width = 150;
            // 
            // olvColumnOrderID
            // 
            this.olvColumnOrderID.AspectName = "OrderID";
            this.olvColumnOrderID.Groupable = false;
            this.olvColumnOrderID.Text = "Order ID";
            this.olvColumnOrderID.Width = 80;
            // 
            // olvColumnCountry
            // 
            this.olvColumnCountry.AspectName = "Country.Name";
            this.olvColumnCountry.Text = "Country";
            this.olvColumnCountry.Width = 100;
            // 
            // olvColumnDate
            // 
            this.olvColumnDate.AspectName = "Date";
            this.olvColumnDate.AspectToStringFormat = "{0:d}";
            this.olvColumnDate.Text = "Date";
            this.olvColumnDate.Width = 75;
            // 
            // olvColumnSupportAmount
            // 
            this.olvColumnSupportAmount.AspectName = "SupportAmount";
            this.olvColumnSupportAmount.AspectToStringFormat = "{0:C2}";
            this.olvColumnSupportAmount.Text = "Support Amount";
            this.olvColumnSupportAmount.Width = 100;
            // 
            // olvColumnReceivedAmount
            // 
            this.olvColumnReceivedAmount.AspectName = "ReceivedAmount";
            this.olvColumnReceivedAmount.AspectToStringFormat = "{0:C2}";
            this.olvColumnReceivedAmount.Text = "Received Amount";
            this.olvColumnReceivedAmount.Width = 100;
            // 
            // olvColumnPartnerShare
            // 
            this.olvColumnPartnerShare.AspectName = "PartnerShare";
            this.olvColumnPartnerShare.AspectToStringFormat = "{0:C2}";
            this.olvColumnPartnerShare.Text = "Partner Share";
            this.olvColumnPartnerShare.Width = 100;
            // 
            // olvColumnPartnerName
            // 
            this.olvColumnPartnerName.AspectName = "Product.PartnerName";
            this.olvColumnPartnerName.Text = "Partner Name";
            this.olvColumnPartnerName.Width = 100;
            // 
            // olvColumnTax
            // 
            this.olvColumnTax.AspectName = "Tax";
            this.olvColumnTax.AspectToStringFormat = "{0:C2}";
            this.olvColumnTax.Text = "Tax";
            this.olvColumnTax.Width = 70;
            // 
            // olvColumnPrice
            // 
            this.olvColumnPrice.AspectName = "Price";
            this.olvColumnPrice.AspectToStringFormat = "{0:C0}";
            this.olvColumnPrice.Text = "Price";
            this.olvColumnPrice.Width = 70;
            // 
            // olvColumnAuthorFee
            // 
            this.olvColumnAuthorFee.AspectName = "PriceAfterAuthorFee";
            this.olvColumnAuthorFee.AspectToStringFormat = "{0:C2}";
            this.olvColumnAuthorFee.Text = "Price after Author Fee";
            this.olvColumnAuthorFee.Width = 121;
            // 
            // olvColumnBuyerFee
            // 
            this.olvColumnBuyerFee.AspectName = "PriceAfterBuyerFee";
            this.olvColumnBuyerFee.AspectToStringFormat = "{0:C0}";
            this.olvColumnBuyerFee.Text = "Price after Buyer Fee";
            this.olvColumnBuyerFee.Width = 120;
            // 
            // olvColumnDetail
            // 
            this.olvColumnDetail.AspectName = "Detail";
            this.olvColumnDetail.Text = "Detail";
            this.olvColumnDetail.Width = 800;
            // 
            // tabPageCountries
            // 
            this.tabPageCountries.Controls.Add(this.objectListViewCountries);
            this.tabPageCountries.Location = new System.Drawing.Point(4, 22);
            this.tabPageCountries.Name = "tabPageCountries";
            this.tabPageCountries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCountries.Size = new System.Drawing.Size(903, 536);
            this.tabPageCountries.TabIndex = 1;
            this.tabPageCountries.Text = "Countries";
            this.tabPageCountries.UseVisualStyleBackColor = true;
            // 
            // objectListViewCountries
            // 
            this.objectListViewCountries.AllColumns.Add(this.olvColumnCountryName);
            this.objectListViewCountries.AllColumns.Add(this.olvColumnCountryTax);
            this.objectListViewCountries.CellEditUseWholeCell = false;
            this.objectListViewCountries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnCountryName,
            this.olvColumnCountryTax});
            this.objectListViewCountries.ContextMenuStrip = this.contextMenuStripCountry;
            this.objectListViewCountries.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewCountries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewCountries.FullRowSelect = true;
            this.objectListViewCountries.Location = new System.Drawing.Point(3, 3);
            this.objectListViewCountries.MultiSelect = false;
            this.objectListViewCountries.Name = "objectListViewCountries";
            this.objectListViewCountries.ShowGroups = false;
            this.objectListViewCountries.Size = new System.Drawing.Size(897, 530);
            this.objectListViewCountries.TabIndex = 0;
            this.objectListViewCountries.UseCompatibleStateImageBehavior = false;
            this.objectListViewCountries.View = System.Windows.Forms.View.Details;
            this.objectListViewCountries.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListViewCountries_ItemsChanged);
            this.objectListViewCountries.SelectedIndexChanged += new System.EventHandler(this.objectListViewCountries_SelectedIndexChanged);
            // 
            // olvColumnCountryName
            // 
            this.olvColumnCountryName.AspectName = "Name";
            this.olvColumnCountryName.Text = "Name";
            this.olvColumnCountryName.UseInitialLetterForGroup = true;
            this.olvColumnCountryName.Width = 200;
            // 
            // olvColumnCountryTax
            // 
            this.olvColumnCountryTax.AspectName = "Tax";
            this.olvColumnCountryTax.AspectToStringFormat = "{0:#0.##%}";
            this.olvColumnCountryTax.Text = "Tax";
            // 
            // tabPageProducts
            // 
            this.tabPageProducts.Controls.Add(this.objectListViewProducts);
            this.tabPageProducts.Location = new System.Drawing.Point(4, 22);
            this.tabPageProducts.Name = "tabPageProducts";
            this.tabPageProducts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProducts.Size = new System.Drawing.Size(903, 536);
            this.tabPageProducts.TabIndex = 2;
            this.tabPageProducts.Text = "Products";
            this.tabPageProducts.UseVisualStyleBackColor = true;
            // 
            // objectListViewProducts
            // 
            this.objectListViewProducts.AllColumns.Add(this.olvColumnProductName);
            this.objectListViewProducts.AllColumns.Add(this.olvColumnProductPrice);
            this.objectListViewProducts.AllColumns.Add(this.olvColumnProductAuthorFee);
            this.objectListViewProducts.AllColumns.Add(this.olvColumnProductBuyerFee);
            this.objectListViewProducts.AllColumns.Add(this.olvColumnProductPartnerShare);
            this.objectListViewProducts.AllColumns.Add(this.olvColumnProductPartnerName);
            this.objectListViewProducts.CellEditUseWholeCell = false;
            this.objectListViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnProductName,
            this.olvColumnProductPrice,
            this.olvColumnProductAuthorFee,
            this.olvColumnProductBuyerFee,
            this.olvColumnProductPartnerShare,
            this.olvColumnProductPartnerName});
            this.objectListViewProducts.ContextMenuStrip = this.contextMenuStripProduct;
            this.objectListViewProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewProducts.FullRowSelect = true;
            this.objectListViewProducts.Location = new System.Drawing.Point(3, 3);
            this.objectListViewProducts.MultiSelect = false;
            this.objectListViewProducts.Name = "objectListViewProducts";
            this.objectListViewProducts.ShowGroups = false;
            this.objectListViewProducts.Size = new System.Drawing.Size(897, 530);
            this.objectListViewProducts.TabIndex = 0;
            this.objectListViewProducts.UseCompatibleStateImageBehavior = false;
            this.objectListViewProducts.View = System.Windows.Forms.View.Details;
            this.objectListViewProducts.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListViewProducts_ItemsChanged);
            this.objectListViewProducts.SelectedIndexChanged += new System.EventHandler(this.objectListViewProducts_SelectedIndexChanged);
            // 
            // olvColumnProductName
            // 
            this.olvColumnProductName.AspectName = "Name";
            this.olvColumnProductName.Text = "Name";
            this.olvColumnProductName.UseInitialLetterForGroup = true;
            this.olvColumnProductName.Width = 400;
            // 
            // olvColumnProductPrice
            // 
            this.olvColumnProductPrice.AspectName = "Price";
            this.olvColumnProductPrice.AspectToStringFormat = "{0:C0}";
            this.olvColumnProductPrice.Text = "Price";
            // 
            // olvColumnProductAuthorFee
            // 
            this.olvColumnProductAuthorFee.AspectName = "AuthorFee";
            this.olvColumnProductAuthorFee.AspectToStringFormat = "{0:#0.##%}";
            this.olvColumnProductAuthorFee.Text = "Author Fee";
            this.olvColumnProductAuthorFee.Width = 98;
            // 
            // olvColumnProductBuyerFee
            // 
            this.olvColumnProductBuyerFee.AspectName = "BuyerFee";
            this.olvColumnProductBuyerFee.AspectToStringFormat = "{0:C0}";
            this.olvColumnProductBuyerFee.Text = "Buyer Fee";
            this.olvColumnProductBuyerFee.Width = 104;
            // 
            // olvColumnProductPartnerShare
            // 
            this.olvColumnProductPartnerShare.AspectName = "PartnerShare";
            this.olvColumnProductPartnerShare.AspectToStringFormat = "{0:#0.##%}";
            this.olvColumnProductPartnerShare.Text = "Partner Share";
            this.olvColumnProductPartnerShare.Width = 91;
            // 
            // olvColumnProductPartnerName
            // 
            this.olvColumnProductPartnerName.AspectName = "PartnerName";
            this.olvColumnProductPartnerName.Text = "Partner Name";
            this.olvColumnProductPartnerName.Width = 150;
            // 
            // tabPageAccounts
            // 
            this.tabPageAccounts.Controls.Add(this.objectListViewAccounts);
            this.tabPageAccounts.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccounts.Name = "tabPageAccounts";
            this.tabPageAccounts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccounts.Size = new System.Drawing.Size(903, 536);
            this.tabPageAccounts.TabIndex = 4;
            this.tabPageAccounts.Text = "Accounts";
            this.tabPageAccounts.UseVisualStyleBackColor = true;
            // 
            // objectListViewAccounts
            // 
            this.objectListViewAccounts.AllColumns.Add(this.olvColumnAccountName);
            this.objectListViewAccounts.AllColumns.Add(this.olvColumnAccountAPIKey);
            this.objectListViewAccounts.CellEditUseWholeCell = false;
            this.objectListViewAccounts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumnAccountName,
            this.olvColumnAccountAPIKey});
            this.objectListViewAccounts.ContextMenuStrip = this.contextMenuStripAccount;
            this.objectListViewAccounts.Cursor = System.Windows.Forms.Cursors.Default;
            this.objectListViewAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectListViewAccounts.FullRowSelect = true;
            this.objectListViewAccounts.Location = new System.Drawing.Point(3, 3);
            this.objectListViewAccounts.MultiSelect = false;
            this.objectListViewAccounts.Name = "objectListViewAccounts";
            this.objectListViewAccounts.ShowGroups = false;
            this.objectListViewAccounts.Size = new System.Drawing.Size(897, 530);
            this.objectListViewAccounts.TabIndex = 1;
            this.objectListViewAccounts.UseCompatibleStateImageBehavior = false;
            this.objectListViewAccounts.View = System.Windows.Forms.View.Details;
            this.objectListViewAccounts.ItemsChanged += new System.EventHandler<BrightIdeasSoftware.ItemsChangedEventArgs>(this.objectListViewAccounts_ItemsChanged);
            this.objectListViewAccounts.SelectedIndexChanged += new System.EventHandler(this.objectListViewAccounts_SelectedIndexChanged);
            // 
            // olvColumnAccountName
            // 
            this.olvColumnAccountName.AspectName = "Name";
            this.olvColumnAccountName.FillsFreeSpace = true;
            this.olvColumnAccountName.Text = "Name";
            this.olvColumnAccountName.UseInitialLetterForGroup = true;
            // 
            // olvColumnAccountAPIKey
            // 
            this.olvColumnAccountAPIKey.AspectName = "APIKey";
            this.olvColumnAccountAPIKey.AspectToStringFormat = "";
            this.olvColumnAccountAPIKey.FillsFreeSpace = true;
            this.olvColumnAccountAPIKey.Text = "API Key";
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.chart);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraph.Size = new System.Drawing.Size(903, 536);
            this.tabPageGraph.TabIndex = 3;
            this.tabPageGraph.Text = "Graph";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // chart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Stacked;
            chartArea1.Name = "ChartArea";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 3);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(897, 530);
            this.chart.TabIndex = 0;
            this.chart.GetToolTipText += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs>(this.chart_GetToolTipText);
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(1127, 562);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // toolStripContainer.LeftToolStripPanel
            // 
            this.toolStripContainer.LeftToolStripPanel.Controls.Add(this.toolStripMain);
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(1164, 586);
            this.toolStripContainer.TabIndex = 3;
            this.toolStripContainer.Text = "toolStripContainer1";
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // toolStripMain
            // 
            this.toolStripMain.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAdd,
            this.toolStripButtonEdit,
            this.toolStripButtonRemove,
            this.toolStripButtonUpdate,
            this.toolStripButtonExport});
            this.toolStripMain.Location = new System.Drawing.Point(0, 7);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripMain.Size = new System.Drawing.Size(37, 206);
            this.toolStripMain.TabIndex = 0;
            // 
            // toolStripButtonAdd
            // 
            this.toolStripButtonAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAdd.Image = global::Sales_Manager.Properties.Resources.add;
            this.toolStripButtonAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAdd.Name = "toolStripButtonAdd";
            this.toolStripButtonAdd.Size = new System.Drawing.Size(35, 36);
            this.toolStripButtonAdd.Text = "Add";
            this.toolStripButtonAdd.Click += new System.EventHandler(this.toolStripButtonAdd_Click);
            // 
            // toolStripButtonEdit
            // 
            this.toolStripButtonEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEdit.Enabled = false;
            this.toolStripButtonEdit.Image = global::Sales_Manager.Properties.Resources.edit;
            this.toolStripButtonEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEdit.Name = "toolStripButtonEdit";
            this.toolStripButtonEdit.Size = new System.Drawing.Size(35, 36);
            this.toolStripButtonEdit.Text = "Edit";
            this.toolStripButtonEdit.Click += new System.EventHandler(this.toolStripButtonEdit_Click);
            // 
            // toolStripButtonRemove
            // 
            this.toolStripButtonRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemove.Enabled = false;
            this.toolStripButtonRemove.Image = global::Sales_Manager.Properties.Resources.remove;
            this.toolStripButtonRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemove.Name = "toolStripButtonRemove";
            this.toolStripButtonRemove.Size = new System.Drawing.Size(35, 36);
            this.toolStripButtonRemove.Text = "Remove";
            this.toolStripButtonRemove.Click += new System.EventHandler(this.toolStripButtonRemove_Click);
            // 
            // toolStripButtonUpdate
            // 
            this.toolStripButtonUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUpdate.Image = global::Sales_Manager.Properties.Resources.update;
            this.toolStripButtonUpdate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdate.Name = "toolStripButtonUpdate";
            this.toolStripButtonUpdate.Size = new System.Drawing.Size(35, 36);
            this.toolStripButtonUpdate.Text = "Update";
            this.toolStripButtonUpdate.Click += new System.EventHandler(this.toolStripButtonUpdate_Click);
            // 
            // toolStripButtonExport
            // 
            this.toolStripButtonExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExport.Image = global::Sales_Manager.Properties.Resources.export_excel;
            this.toolStripButtonExport.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExport.Name = "toolStripButtonExport";
            this.toolStripButtonExport.Size = new System.Drawing.Size(35, 36);
            this.toolStripButtonExport.Text = "Export";
            this.toolStripButtonExport.Click += new System.EventHandler(this.toolStripButtonExport_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpMenuToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip.TabIndex = 0;
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoRefreshToolStripMenuItem,
            this.minimizeToTrayToolStripMenuItem,
            this.enableUpdateNotificationToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // autoRefreshToolStripMenuItem
            // 
            this.autoRefreshToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thirtyMinutesToolStripMenuItem,
            this.oneHourToolStripMenuItem,
            this.twoHourToolStripMenuItem,
            this.threeHourToolStripMenuItem,
            this.fourHourToolStripMenuItem});
            this.autoRefreshToolStripMenuItem.Image = global::Sales_Manager.Properties.Resources.refresh_all;
            this.autoRefreshToolStripMenuItem.Name = "autoRefreshToolStripMenuItem";
            this.autoRefreshToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.autoRefreshToolStripMenuItem.Text = "Auto Refresh";
            this.autoRefreshToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.refreshToolStripMenuItem_DropDownItemClicked);
            // 
            // thirtyMinutesToolStripMenuItem
            // 
            this.thirtyMinutesToolStripMenuItem.Name = "thirtyMinutesToolStripMenuItem";
            this.thirtyMinutesToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.thirtyMinutesToolStripMenuItem.Text = "30 Minutes";
            // 
            // oneHourToolStripMenuItem
            // 
            this.oneHourToolStripMenuItem.Name = "oneHourToolStripMenuItem";
            this.oneHourToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.oneHourToolStripMenuItem.Text = "1 Hour";
            // 
            // twoHourToolStripMenuItem
            // 
            this.twoHourToolStripMenuItem.Name = "twoHourToolStripMenuItem";
            this.twoHourToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.twoHourToolStripMenuItem.Text = "2 Hour";
            // 
            // threeHourToolStripMenuItem
            // 
            this.threeHourToolStripMenuItem.Name = "threeHourToolStripMenuItem";
            this.threeHourToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.threeHourToolStripMenuItem.Text = "3 Hour";
            // 
            // fourHourToolStripMenuItem
            // 
            this.fourHourToolStripMenuItem.Name = "fourHourToolStripMenuItem";
            this.fourHourToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.fourHourToolStripMenuItem.Text = "4 Hour";
            // 
            // minimizeToTrayToolStripMenuItem
            // 
            this.minimizeToTrayToolStripMenuItem.CheckOnClick = true;
            this.minimizeToTrayToolStripMenuItem.Name = "minimizeToTrayToolStripMenuItem";
            this.minimizeToTrayToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.minimizeToTrayToolStripMenuItem.Text = "Minimize to Tray";
            this.minimizeToTrayToolStripMenuItem.CheckedChanged += new System.EventHandler(this.minimizeToTrayToolStripMenuItem_CheckedChanged);
            // 
            // enableUpdateNotificationToolStripMenuItem
            // 
            this.enableUpdateNotificationToolStripMenuItem.CheckOnClick = true;
            this.enableUpdateNotificationToolStripMenuItem.Name = "enableUpdateNotificationToolStripMenuItem";
            this.enableUpdateNotificationToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.enableUpdateNotificationToolStripMenuItem.Text = "Enable Update Notification";
            this.enableUpdateNotificationToolStripMenuItem.CheckedChanged += new System.EventHandler(this.enableUpdateNotificationToolStripMenuItem_CheckedChanged);
            // 
            // helpMenuToolStripMenuItem
            // 
            this.helpMenuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.supportToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpMenuToolStripMenuItem.Name = "helpMenuToolStripMenuItem";
            this.helpMenuToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpMenuToolStripMenuItem.Text = "Help";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Image = global::Sales_Manager.Properties.Resources.book;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // supportToolStripMenuItem
            // 
            this.supportToolStripMenuItem.Image = global::Sales_Manager.Properties.Resources.comment_box;
            this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
            this.supportToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.supportToolStripMenuItem.Text = "Support";
            this.supportToolStripMenuItem.Click += new System.EventHandler(this.supportToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Sales_Manager.Properties.Resources.info_rhombus;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Comma Separated Values File (*.csv)|*.csv";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "Double click this icon to open Sales Manager again.";
            this.notifyIcon.BalloonTipTitle = "Where is my application?";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotifyIcon;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Sales Manager";
            this.notifyIcon.BalloonTipClicked += new System.EventHandler(this.notifyIcon_BalloonTipClicked);
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStripNotifyIcon
            // 
            this.contextMenuStripNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
            this.contextMenuStripNotifyIcon.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 586);
            this.Controls.Add(this.toolStripContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1024, 625);
            this.Name = "FormMain";
            this.Text = "Sales Manager - Track your Envato market sales";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.contextMenuStripTransaction.ResumeLayout(false);
            this.contextMenuStripCountry.ResumeLayout(false);
            this.contextMenuStripProduct.ResumeLayout(false);
            this.contextMenuStripAccount.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).EndInit();
            this.groupBoxAccount.ResumeLayout(false);
            this.groupBoxTotalSales.ResumeLayout(false);
            this.groupBoxTotalSales.PerformLayout();
            this.groupBoxTotal.ResumeLayout(false);
            this.groupBoxTotal.PerformLayout();
            this.groupBoxPartnerShare.ResumeLayout(false);
            this.groupBoxPartnerShare.PerformLayout();
            this.groupBoxIncome.ResumeLayout(false);
            this.groupBoxIncome.PerformLayout();
            this.groupBoxMonthYear.ResumeLayout(false);
            this.groupBoxProducts.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageTransactions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewTransactions)).EndInit();
            this.tabPageCountries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewCountries)).EndInit();
            this.tabPageProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewProducts)).EndInit();
            this.tabPageAccounts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.objectListViewAccounts)).EndInit();
            this.tabPageGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStripNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripCountry;
        private System.Windows.Forms.ToolStripMenuItem editCountryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeCountryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripProduct;
        private System.Windows.Forms.ToolStripMenuItem editProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeProductToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripTransaction;
        private System.Windows.Forms.ToolStripMenuItem editTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTransactionToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxMonthYear;
        private System.Windows.Forms.GroupBox groupBoxProducts;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonAdd;
        private System.Windows.Forms.ToolStripButton toolStripButtonEdit;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemove;
        private System.Windows.Forms.GroupBox groupBoxIncome;
        private System.Windows.Forms.Label labelIncome;
        private System.Windows.Forms.GroupBox groupBoxPartnerShare;
        private System.Windows.Forms.Label labelPartnerShare;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdate;
        private System.Windows.Forms.GroupBox groupBoxTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.GroupBox groupBoxTotalSales;
        private System.Windows.Forms.Label labelTotalSales;
        private System.Windows.Forms.ToolStripButton toolStripButtonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.GroupBox groupBoxAccount;
        private System.Windows.Forms.ComboBox comboBoxAccounts;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAccount;
        private System.Windows.Forms.ToolStripMenuItem editAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeAccountToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fourHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirtyMinutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oneHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem twoHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threeHourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableUpdateNotificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageTransactions;
        private BrightIdeasSoftware.ObjectListView objectListViewTransactions;
        private BrightIdeasSoftware.OLVColumn olvColumnName;
        private BrightIdeasSoftware.OLVColumn olvColumnOrderID;
        private BrightIdeasSoftware.OLVColumn olvColumnCountry;
        private BrightIdeasSoftware.OLVColumn olvColumnDate;
        private BrightIdeasSoftware.OLVColumn olvColumnSupportAmount;
        private BrightIdeasSoftware.OLVColumn olvColumnReceivedAmount;
        private BrightIdeasSoftware.OLVColumn olvColumnPartnerShare;
        private BrightIdeasSoftware.OLVColumn olvColumnPartnerName;
        private BrightIdeasSoftware.OLVColumn olvColumnTax;
        private BrightIdeasSoftware.OLVColumn olvColumnPrice;
        private BrightIdeasSoftware.OLVColumn olvColumnAuthorFee;
        public BrightIdeasSoftware.OLVColumn olvColumnBuyerFee;
        private BrightIdeasSoftware.OLVColumn olvColumnDetail;
        private System.Windows.Forms.TabPage tabPageCountries;
        private BrightIdeasSoftware.ObjectListView objectListViewCountries;
        private BrightIdeasSoftware.OLVColumn olvColumnCountryName;
        private BrightIdeasSoftware.OLVColumn olvColumnCountryTax;
        private System.Windows.Forms.TabPage tabPageProducts;
        private BrightIdeasSoftware.ObjectListView objectListViewProducts;
        private BrightIdeasSoftware.OLVColumn olvColumnProductName;
        private BrightIdeasSoftware.OLVColumn olvColumnProductPrice;
        private BrightIdeasSoftware.OLVColumn olvColumnProductAuthorFee;
        private BrightIdeasSoftware.OLVColumn olvColumnProductBuyerFee;
        private BrightIdeasSoftware.OLVColumn olvColumnProductPartnerShare;
        private BrightIdeasSoftware.OLVColumn olvColumnProductPartnerName;
        private System.Windows.Forms.TabPage tabPageAccounts;
        private BrightIdeasSoftware.ObjectListView objectListViewAccounts;
        private BrightIdeasSoftware.OLVColumn olvColumnAccountName;
        private BrightIdeasSoftware.OLVColumn olvColumnAccountAPIKey;
        private System.Windows.Forms.TabPage tabPageGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.PictureBox pictureBoxDonate;
    }
}

