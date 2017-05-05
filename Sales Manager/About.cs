using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Sales_Manager
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            HelperMethods.FixFonts(this);
        }

        private void buttonWebsite_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://rbsoft.org");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonForum_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/ravibpatel/SalesManager/issues");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void About_Load(object sender, EventArgs e)
        {
            labelName.Text = $@"{Application.ProductName} {Application.ProductVersion}";
            labelCopyright.Text = $@"Copyright © 2017 {Application.CompanyName}";
        }

        private void richTextBoxCredits_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            try
            {
                Process.Start(e.LinkText);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBoxEnvatoAPI_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://build.envato.com/");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, e.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}