using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sales_Manager
{
    public partial class GetSales : Form
    {
        public GetSales(DateTime fromDate, DateTime toDate, Account account)
        {
            InitializeComponent();
            HelperMethods.FixFonts(this);
            var backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += delegate(object sender, DoWorkEventArgs args) {
                args.Result = Transaction.GetSales(fromDate, toDate, account, backgroundWorker);
            };
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;
            backgroundWorker.RunWorkerCompleted += delegate(object sender, RunWorkerCompletedEventArgs args)
            {
                Close();
                DialogResult = args.Result.Equals(false) ? DialogResult.Cancel : DialogResult.OK;
            };
            backgroundWorker.RunWorkerAsync();
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            if (e.UserState.Equals(1)) { 
                progressBar.Style = ProgressBarStyle.Blocks;
                labelInfo.Text = @"Calculating fees...";
            }
        }
    }
}
