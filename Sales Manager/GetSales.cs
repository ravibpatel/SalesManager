using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Sales_Manager
{
    public partial class GetSales : Form
    {
        public GetSales(DateTime fromDate, DateTime toDate, Account account, bool hide)
        {
            InitializeComponent();
            HelperMethods.FixFonts(this);

            if (hide)
            {
                StartPosition = FormStartPosition.CenterScreen;
                WindowState = FormWindowState.Minimized;
            }

            var backgroundWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true
            };

            backgroundWorker.DoWork += delegate (object sender, DoWorkEventArgs args)
            {
                args.Result = Transaction.GetSales(fromDate, toDate, account, backgroundWorker);
            };

            backgroundWorker.ProgressChanged += delegate (object sender, ProgressChangedEventArgs args)
            {
                progressBar.Value = args.ProgressPercentage;
                if (args.UserState.Equals(1))
                {
                    progressBar.Style = ProgressBarStyle.Blocks;
                    labelInfo.Text = @"Calculating fees...";
                }
            };

            backgroundWorker.RunWorkerCompleted += delegate (object sender, RunWorkerCompletedEventArgs args)
            {
                Close();
                DialogResult = args.Result.Equals(false) ? DialogResult.Cancel : DialogResult.OK;
            };

            backgroundWorker.RunWorkerAsync();
        }
    }
}
