using System;
using System.Linq;
using System.Windows.Forms;
using Sales_Manager.Properties;

namespace Sales_Manager
{
    public partial class AddProduct : Form
    {
        private readonly Product _product;

        private readonly Account _account;

        public AddProduct(Account account, Product product = null)
        {
            InitializeComponent();
            _product = product;
            _account = account;
            HelperMethods.FixFonts(this);
            if (_product!= null)
            {
                buttonSave.Text = @"Save";
                Text = @"Edit Product";
                textBoxName.Text = _product.Name;
                numericUpDownPrice.Value = (decimal) _product.Price;
                numericUpDownAuthorFee.Value = (decimal) _product.AuthorFee * 100;
                numericUpDownBuyerFee.Value = (decimal) _product.BuyerFee;
                numericUpDownPartnerShare.Value = (decimal) _product.PartnerShare * 100;
                numericUpDownID.Value = _product.ID;
                textBoxPartnerName.Text = _product.PartnerName;
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, Resources.nameRequiredMessage);
                DialogResult = DialogResult.None;
            }
            using (var db = new SalesManagerContext())
            {
                if (_product == null)
                {
                    if (db.Products.Any(item => item.Name.Equals(textBoxName.Text.Trim())))
                    {
                        errorProvider.SetError(textBoxName, Resources.productExistErrorMessage);
                        DialogResult = DialogResult.None;
                    }
                }
                else
                {
                    if (db.Products.FirstOrDefault(item => item.Name.Equals(textBoxName.Text.Trim()) && !item.ID.Equals(_product.ID)) != null)
                    {
                        errorProvider.SetError(textBoxName, Resources.productExistErrorMessage);
                        DialogResult = DialogResult.None;
                    }
                }
                if (numericUpDownID.Value.Equals(0))
                {
                    errorProvider.SetError(numericUpDownID, Resources.invalidProductIDErrorMessage);
                    DialogResult = DialogResult.None;
                }
                else
                {
                    if (_product == null)
                    {
                        if (db.Products.Any(item => item.ID.Equals((int) numericUpDownID.Value)))
                        {
                            errorProvider.SetError(numericUpDownID, Resources.productIDExistErrorMessage);
                            DialogResult = DialogResult.None;
                        }
                    }
                    else
                    {
                        if (db.Products.FirstOrDefault(item => item.ID.Equals((int)numericUpDownID.Value) && !item.ID.Equals(_product.ID)) != null)
                        {
                            errorProvider.SetError(numericUpDownID, Resources.productIDExistErrorMessage);
                            DialogResult = DialogResult.None;
                        }
                    }
                }
                if (DialogResult.Equals(DialogResult.None))
                {
                    return;
                }
                var product = _product ?? new Product();
                product.Name = textBoxName.Text.Trim();
                product.Price = (double) numericUpDownPrice.Value;
                product.AuthorFee = (double) numericUpDownAuthorFee.Value * 0.01;
                product.BuyerFee = (double) numericUpDownBuyerFee.Value;
                product.PartnerShare = (double) numericUpDownPartnerShare.Value * 0.01;
                product.ID = (int) numericUpDownID.Value;
                product.PartnerName = textBoxPartnerName.Text.Trim();
                if (_product != null)
                {
                    product.Edit();
                }
                else
                {
                    product.Account = _account;
                    product.Add();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "managing_products.htm");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
