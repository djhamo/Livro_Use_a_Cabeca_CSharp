using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayParty
{
    class DinnerParty : Party
    {

        public decimal CostOfBeveragesPerPerson { get; set; }

        public DinnerParty(int numberOfPeople, bool healthyOption, bool fancyDecoration)
            : base(numberOfPeople, fancyDecoration)
        {
            SetHealthyOption(healthyOption);
        }
        public void SetHealthyOption(bool checkHelth)
        {
            if (checkHelth) 
                CostOfBeveragesPerPerson = 5.00M;
            else 
                CostOfBeveragesPerPerson = 20.00M;

        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople);
            if (healthyOption)
                return totalCost * .95M;
            else
                return totalCost;
        }


    }
}
