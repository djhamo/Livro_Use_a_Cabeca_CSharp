using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost();
            lbCoast.Text = Cost.ToString("c");
        }
        private void numPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void ckFancy_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(ckFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void ckHealth_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(ckHealth.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
