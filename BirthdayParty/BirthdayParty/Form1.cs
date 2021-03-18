using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numPeople.Value, ckHealth.Checked, ckFancy.Checked);
            dinnerParty.SetHealthyOption(false);
            //dinnerParty.CalculateCostOfDecorations(true);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, cakeText.Text);
            DisplayBirthdayPartyCost();
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(ckHealth.Checked);
            lbCoast.Text = Cost.ToString("c");
        }

        public void DisplayBirthdayPartyCost()
        {
            cakeText.Text = birthdayParty.CakeWriting;
            decimal Cost = birthdayParty.CalculateCost();
            birthdayCost.Text = Cost.ToString("c");
        }

        private void numPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numPeople.Value;
            DisplayDinnerPartyCost();
        }

        private void ckFancy_CheckedChanged(object sender, EventArgs e)
        {
            //dinnerParty.SetHealthyOption(ckFancy.Checked);
            DisplayDinnerPartyCost();
        }

        private void ckHealth_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOption(ckHealth.Checked);
            DisplayDinnerPartyCost();
        }

        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            //birthdayParty.CalculateCostOfDecorations(fancyBirthday.Checked);
            DisplayBirthdayPartyCost();
        }

        private void cakeText_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeText.Text;
            DisplayBirthdayPartyCost();
        }
    }
}
