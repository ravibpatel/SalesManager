using System;
using System.Linq;
using System.Windows.Forms;
using Sales_Manager.Properties;

namespace Sales_Manager
{
    public partial class AddCountry : Form
    {
        private readonly Country _country;

        public AddCountry(Country country = null)
        {
            _country = country;
            InitializeComponent();
            HelperMethods.FixFonts(this);
            if (_country != null)
            {
                Text = @"Edit Country";
                buttonSave.Text = @"Save";
                textBoxName.Text = _country.Name;
                numericUpDownTax.Value = (decimal) _country.Tax * 100;
            }
        }

        public sealed override string Text
        {
            get => base.Text;
            set => base.Text = value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                errorProvider.SetError(textBoxName, Resources.nameRequiredMessage);
                DialogResult = DialogResult.None;
                return;
            }
            using (var db = new SalesManagerContext())
            {
                if (_country == null)
                {
                    if (db.Countries.Any(item => item.Name.Equals(textBoxName.Text.Trim())))
                    {
                        errorProvider.SetError(textBoxName, Resources.countryExistErrorMessage);
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
                else
                {
                    if (db.Countries.FirstOrDefault(item => item.Name.Equals(textBoxName.Text.Trim()) && !item.ID.Equals(_country.ID)) != null)
                    {
                        errorProvider.SetError(textBoxName, Resources.countryExistErrorMessage);
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
            }
            if (_country != null)
            {
                _country.Name = textBoxName.Text.Trim();
                _country.Tax = (double) numericUpDownTax.Value * 0.01;
                _country.Edit();
            }
            else
            {
                var country = new Country
                {
                    Name = textBoxName.Text.Trim(),
                    Tax = (int) numericUpDownTax.Value * 0.01
                };
                country.Add();
            }
        }
    }
}
