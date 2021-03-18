using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirthdayParty
{
    class Party
    {
        private const decimal CostOfFoodPerPerson = 25M;
        public bool FancyDecoration { get; private set; }

        private decimal costOfDecoration = 0;
        public decimal CostOfDecoration
        {
            get {
                if (FancyDecoration) costOfDecoration = (NumberOfPeople * 15.00M) + 50M;
                else costOfDecoration = (NumberOfPeople * 7.50M) + 30M;
                return costOfDecoration;
            }

        }
        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.FancyDecoration = fancyDecorations;
        }

        private int numberOfPeople = 0;
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
            }
        }

        public virtual decimal CalculateCost()
        {
            if (NumberOfPeople == 0)
                return 0m;
            
            decimal TotalCost = CostOfDecoration + (CostOfFoodPerPerson * NumberOfPeople);
            if (numberOfPeople > 12)
                TotalCost += 100M;

            return TotalCost;
        }


    }
}
