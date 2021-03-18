using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayParty
{
    class BirthdayParty : Party
    {
        public const int CostOfFoodPerPerson = 25;

        private bool fancyDecorations;
        public int CakeSize;

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }



        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        private string cakeWriting = "";
        public string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLenght;
                if (CakeSize == 8)
                    maxLenght = 16;
                else
                    maxLenght = 40;

                if (value.Length > maxLenght)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize + " inch Cake");
                    if (maxLenght > this.cakeWriting.Length)
                        maxLenght = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLenght);
                }
                else
                    this.cakeWriting = value;
            }
        }

        public override decimal CalculateCost()
        {
            decimal CakeCost;
            if (CakeSize == 8)
                CakeCost = 40M + CakeWriting.Length * .25M;
            else
                CakeCost = 75M + CakeWriting.Length * .25M;

            return base.CalculateCost() + CakeCost;
        }

    }
}
