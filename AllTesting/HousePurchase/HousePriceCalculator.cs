using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePurchase
{
    class HousePriceCalculator : IHousePriceCalculator
    {
        int monthsInAYear = 12;

        public double CalculateDownPaymentOnHouse(double housePrice, double percentageNeeded)
        {
            double amountNeededToBuyHouse = (housePrice / 100) * percentageNeeded;

            return amountNeededToBuyHouse;
        }

        public double CalculateEstimatedHouseLoanAvailable(double monthlyIncome, double approximateMultiplier)
        {
            double yearlyIncome = monthlyIncome * monthsInAYear;

            double approximateHousePurchaseAmount = yearlyIncome * approximateMultiplier;

            return approximateHousePurchaseAmount;
        }

        public bool DoesUserHaveRequiredDownPayment(double savings, double housePrice, double housePurchasePercentage)
        {
            double amountNeededToBuyHouse = (housePrice / 100) * housePurchasePercentage;

            if (savings >= amountNeededToBuyHouse) return true;

            return false;
        }
    }
}
