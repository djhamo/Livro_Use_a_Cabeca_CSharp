using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        private const decimal CostOfFoodPerPerson = 25M;
        private int numberOfPeople = 0;
        private bool isFancy = false;
        private bool isHealth = false;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set { 
                numberOfPeople = value; 
                CalculateCostOfDecorations(isFancy);
                SetHealthyOption(isHealth);
            }
        }
        public decimal CostOfBeveragesPerPerson { get; set; }
        public decimal CostOfDecoration { get; set; }

        public void SetHealthyOption(bool checkHelth)
        {
            isHealth = checkHelth;
            if (checkHelth) CostOfBeveragesPerPerson = 5.00M;
            else CostOfBeveragesPerPerson = 20.00M;

        }
        public void CalculateCostOfDecorations(bool checkFancy)
        {
            isFancy = checkFancy;
            if (checkFancy) CostOfDecoration = (NumberOfPeople * 15.00M) + 50M;
            else CostOfDecoration = (NumberOfPeople * 7.50M) + 30M;
        }
        public decimal CalculateCost()
        {
            decimal totalCost =  CostOfDecoration +  ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);
            if (isHealth) return totalCost * .95M;
            return totalCost;
        }
    }
}
