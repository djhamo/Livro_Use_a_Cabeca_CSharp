using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackgroundWorker2
{
    public partial class Form1 : Form
    {
        public myStatus Status { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Console.WriteLine("Backgorund worker argument: " + (e.Argument ?? "null"));
            Guy temp = e.Argument as Guy;

            for (int i = 0; i <= 100; i++)
            {
                WasteCPUCycle();
                backgroundWorker1.ReportProgress(i, Status);
                if (backgroundWorker1.CancellationPending)
                {
                    Status = myStatus.Cancelado;
                    Console.WriteLine("Cancelled");
                    break;
                }
            }
            Status = myStatus.Finalizado;
            e.Result = Status;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lbStatus.Text = "Passo: " + e.UserState.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            goButton.Enabled = true;
            cancelButton.Enabled = false;
            Status = myStatus.Finalizado;
            lbStatus.Text = "Passo: " + e.Result.ToString();

        }

        ///<sumary>
        /// Waste CPU cycles causing the program to slow down doing calculation for 100ms
        /// </sumary>
        /// 
        private void WasteCPUCycle()
        {
            DateTime startTime = DateTime.Now;
            double value = Math.E;
            while (DateTime.Now < startTime.AddMilliseconds(100))
            {
                value /= Math.PI;
                value *= Math.Sqrt(2);
            }
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            goButton.Enabled = false;
            Status = myStatus.ExecutandoAsync;
            if (!useBackgroundWorkerCheckbox.Checked)
            {
                for (int i = 0; i < 100; i++)
                {
                    WasteCPUCycle();
                    progressBar1.Value = i;
                    lbStatus.Text = "Passo: " + i;
                }
                goButton.Enabled = true;
            }
            else
            {
                cancelButton.Enabled = true;
                backgroundWorker1.RunWorkerAsync(new Guy("Mané", 24, 15000));
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }
    }

    public enum myStatus
    {
        Parado,
        ExecutandoAsync,
        Finalizado,
        MetadeCaminho,
        Cancelado,
    }
}
