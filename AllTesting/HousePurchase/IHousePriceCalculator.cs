using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePurchase
{
    interface IHousePriceCalculator
    {
        double CalculateDownPaymentOnHouse(double housePrice, double percentageNeeded);
        double CalculateEstimatedHouseLoanAvailable(double yearlyIncome, double approximateMultiplier);
        bool DoesUserHaveRequiredDownPayment(double savings, double housePrice, double housePurchasePercentage);
    }
}
