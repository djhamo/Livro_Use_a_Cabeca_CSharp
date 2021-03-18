using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FibonacciCalculator
{
    public partial class FibonacciForm : Form
    {
        private int numberToCompute = 0;
        private int highestPercentageReached = 0;

        public FibonacciForm()
        {
            InitializeComponent();
            //InitializeBackgroundWorker();
        }

        private void InitializeBackgroundWorker()
        {
            backgroundWorker1.DoWork +=
                new DoWorkEventHandler(bk_DoWork);
            backgroundWorker1.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(bk_RunWorkerComplete);
            backgroundWorker1.ProgressChanged +=
                new ProgressChangedEventHandler(bk_ProgressChanged);

        }

        private void bk_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            e.Result = ComputeFibonacci((int)e.Argument, worker, e);
        }

        private void bk_RunWorkerComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                resultLabel.Text = "Canceled";
            }
            else
            {
                resultLabel.Text = e.Result.ToString();

            }

            numericUpDown1.Enabled = true;
            startAsyncButton.Enabled = true;
            cancelAsyncButton.Enabled = false;

        }

        private void bk_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = String.Empty;
            numericUpDown1.Enabled = false;
            startAsyncButton.Enabled = false;
            cancelAsyncButton.Enabled = true;

            numberToCompute = (int)numericUpDown1.Value;
            highestPercentageReached = 0;
            backgroundWorker1.RunWorkerAsync(numberToCompute);
        }

        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
            numericUpDown1.Enabled = true;
            startAsyncButton.Enabled = true;
            cancelAsyncButton.Enabled = false;
        }

        long ComputeFibonacci(int n, BackgroundWorker worker, DoWorkEventArgs e)
        {
            // Vamos de recursão
            if ((n < 0) || (n > 91))
            {
                throw new ArgumentException("O Valor deve estar entre 0 e 91", "n");
            }

            long result = 0;

            if (worker.CancellationPending)
                e.Cancel = true;
            else
            {
                if (n < 2)
                    result = 1;
                else
                    result = ComputeFibonacci(n - 1, worker, e) 
                        + ComputeFibonacci(n - 2, worker, e);

                int percentageComplete = (int)((float)n / (float)numberToCompute * 100);
                if (percentageComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentageComplete;
                    //Esse cara tem q rodar aqui
                    worker.ReportProgress(percentageComplete);
                    
                }
                //worker.ReportProgress(percentageComplete);
                
            }

            return result;
        }
    }
}
