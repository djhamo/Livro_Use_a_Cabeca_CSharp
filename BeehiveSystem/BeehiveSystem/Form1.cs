using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeehiveSystem
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting manufacturing" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);

            queen = new Queen(workers);
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssingWork(workerBeeJob.Text, (int)nunUpDOwnShift.Value) == false)
                MessageBox.Show("No workers ara available to do the job" + workerBeeJob.Text, "The Queen Says ..");
            else
                MessageBox.Show("The Job " + workerBeeJob.Text + " will be DONE in " + nunUpDOwnShift.Value + " shifts", "The Queen Says ...");

        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkNextShift();
        }

        private void workerBeeJob_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
