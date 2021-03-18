using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitKey
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Game Over");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            const int stage1 = 10;
            const int stage2 = 7;
            const int stage3 = 2;

            const int easy = 400;
            const int medium = 250;
            const int hard = 100;

            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();

                if (timer1.Interval > easy) timer1.Interval -= stage1;
                if (timer1.Interval > medium) timer1.Interval -= stage2;
                if (timer1.Interval > hard) timer1.Interval -= stage3;

                difficultProgressBar.Value = 800 - timer1.Interval;

                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            correctLabel.Text = "Correct: " + stats.Correct;
            missedLabel.Text = "Missed: " + stats.Missed;
            totalLabel.Text = "Total: " + stats.Total;
            acuracyLabel.Text = "Accuracy: " + stats.Accuracy.ToString() + "%";
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
