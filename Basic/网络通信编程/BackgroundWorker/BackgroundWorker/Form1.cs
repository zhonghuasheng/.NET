using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void btnStart_Click( object sender, EventArgs e )
        {
            if (backgroundWorker1.IsBusy != true)
            {
                //开始执行后台程序
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void btnStop_Click( object sender, EventArgs e )
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
        }

        private void backgroundWorker1_DoWork( object sender, DoWorkEventArgs e )
        {
          
            for (int i = 1; i <= 10; i++)
            {
                if (this.backgroundWorker1.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    System.Threading.Thread.Sleep(500);
                    this.backgroundWorker1.ReportProgress(i*10);
                }
            }

        }

        private void backgroundWorker1_ProgressChanged( object sender, ProgressChangedEventArgs e )
        {
            label1.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted( object sender, RunWorkerCompletedEventArgs e )
        {
            if (e.Cancelled == true)
            {
                label1.Text = "Cancled!";
            }
            else if (e.Error != null)
            {
                label1.Text = "Error:" + e.Error.Message;
            }
            else
            {
                label1.Text = "Done!";
            }
        }
    }
}
