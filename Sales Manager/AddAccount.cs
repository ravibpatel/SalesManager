using System;
using System.Linq;
using System.Windows.Forms;
using Sales_Manager.Properties;

namespace Sales_Manager
{
    public partial class AddAccount : Form
    {
        private readonly Account _account;

        public AddAccount(Account account = null)
        {
            _account = account;
            InitializeComponent();
            HelperMethods.FixFonts(this);
            if (_account != null)
            {
                Text = @"Edit Account";
                buttonSave.Text = @"Save";
                textBoxName.Text = _account.Name;
                textBoxAPIKey.Text = _account.APIKey;
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
                if (_account == null)
                {
                    if (db.Accounts.Any(item => item.APIKey.Equals(textBoxAPIKey.Text.Trim())))
                    {
                        errorProvider.SetError(textBoxName, Resources.accountExistErrorMessage);
                        DialogResult = DialogResult.None;
                        return;
                    }
                }
                else if (db.Accounts.FirstOrDefault(item => item.APIKey.Equals(textBoxAPIKey.Text.Trim()) && !item.ID.Equals(_account.ID)) != null)
                {
                    errorProvider.SetError(textBoxName, Resources.accountExistErrorMessage);
                    DialogResult = DialogResult.None;
                    return;
                }
            }
            if (_account != null)
            {
                _account.Name = textBoxName.Text.Trim();
                _account.APIKey = textBoxAPIKey.Text.Trim();
                _account.Edit();
            }
            else
            {
                var account = new Account
                {
                    Name = textBoxName.Text.Trim(),
                    APIKey = textBoxAPIKey.Text.Trim()
                };
                account.Add();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            using (var db = new SalesManagerContext())
            {
                if (db.Accounts.Count().Equals(0))
                {
                    var dialogResult = MessageBox.Show(Resources.needAccountMessage,
                        Resources.needAccountCaption, MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand);
                    if (dialogResult.Equals(DialogResult.Retry))
                    {
                        DialogResult = DialogResult.None;
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Help.ShowHelp(this, "Help.chm", HelpNavigator.Topic, "getting_started.htm");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, exception.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
