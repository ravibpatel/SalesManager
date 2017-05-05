using System;
using System.Linq;
using System.Windows.Forms;
using Sales_Manager.Properties;

namespace Sales_Manager
{
    public partial class AddTransaction : Form
    {
        private readonly Transaction _transaction;

        private readonly Account _account;

        public AddTransaction(Account account, Transaction transaction = null)
        {
            InitializeComponent();
            _transaction = transaction;
            _account = account;
            HelperMethods.FixFonts(this);
            using (var db = new SalesManagerContext())
            {
                comboBoxProduct.DataSource = db.Products.Where(product => !product.ID.Equals(1) && !product.ID.Equals(2)).ToList();
                comboBoxProduct.DisplayMember = "Name";
                comboBoxCountry.DataSource = db.Countries.Where(country => !country.ID.Equals(1)).ToList().ToList();
                comboBoxCountry.DisplayMember = "Name";
            }
            if (transaction != null)
            {
                Text = @"Edit Transaction";
                buttonSave.Text = @"Save";
                textBoxDetail.Text = transaction.Detail;
                comboBoxProduct.Text = transaction.Product.Name;
                comboBoxCountry.Text = transaction.Country.Name;
                textBoxOrderID.Text = transaction.OrderID;
                dateTimePicker.Value = transaction.Date;
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBoxProduct, Resources.productRequiredMessage);
                DialogResult = DialogResult.None;
            }
            if (comboBoxCountry.SelectedIndex < 0)
            {
                errorProvider.SetError(comboBoxCountry, Resources.countryRequiredMessage);
                DialogResult = DialogResult.None;
            }
            if (string.IsNullOrWhiteSpace(textBoxOrderID.Text.Trim()))
            {
                errorProvider.SetError(textBoxOrderID, Resources.emptyOrderIDErrorMessage);
                DialogResult = DialogResult.None;
            }
            if (!string.IsNullOrWhiteSpace(textBoxOrderID.Text))
            {
                using (var db = new SalesManagerContext())
                {
                    if (_transaction == null)
                    {
                        if (db.Transactions.Any(item => item.OrderID.Equals(textBoxOrderID.Text.Trim()) &&
                                                        item.Product.ID.Equals(((Product) comboBoxProduct.SelectedItem)
                                                            .ID)))
                        {
                            errorProvider.SetError(textBoxOrderID, Resources.transactionOrderIDExistErrorMessage);
                            DialogResult = DialogResult.None;
                        }
                    }
                    else
                    {
                        if (db.Transactions.FirstOrDefault(item => item.OrderID.Equals(textBoxOrderID.Text.Trim()) &&
                                                        item.Product.ID.Equals(((Product)comboBoxProduct.SelectedItem)
                                                            .ID) && !item.ID.Equals(_transaction.ID)) != null)
                        {
                            errorProvider.SetError(textBoxOrderID, Resources.transactionOrderIDExistErrorMessage);
                            DialogResult = DialogResult.None;
                        }
                    }
                }
            }
            if (DialogResult.Equals(DialogResult.None))
            {
                return;
            }
            var transaction = _transaction ?? new Transaction();
            using (var db = new SalesManagerContext())
            {
                transaction.Product = (Product)comboBoxProduct.SelectedItem;
                transaction.Country = (Country)comboBoxCountry.SelectedItem;
                transaction.OrderID = textBoxOrderID.Text.Trim();
                transaction.Detail = textBoxDetail.Text.Trim();
                transaction.Date = dateTimePicker.Value.Date;
                if (_transaction != null)
                {
                    transaction.Edit();
                }
                else
                {
                    transaction.Account = _account;
                    transaction.Add();
                }
            }
        }
    }
}
