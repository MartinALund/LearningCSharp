using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HousePurchase
{
    public class HousePurchaseTests
    {

        [Theory]

        [InlineData(2500000, 3, 75000)]
        [InlineData(3000000, 3, 90000)]
        [InlineData(2500000, 5, 125000)]
        [InlineData(3000000, 5, 150000)]
        [InlineData(2395000, 5, 119750)]
        [InlineData(2190000, 5, 109500)]
        [InlineData(1500000, 5, 75000)]
        [InlineData(7500000, 5, 375000)]
        [InlineData(11500000, 5, 575000)]
        [InlineData(2500000, 10, 250000)]
        [InlineData(3000000, 10, 300000)]
        public void CalculateDownPaymentNeeded(double housePrice, double percentageNeeded, double expectedResult)
        {
            var sut = new HousePriceCalculator();

            double actualResult = sut.CalculateDownPaymentOnHouse(housePrice, percentageNeeded);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(55000, 3.5, 2310000)]
        [InlineData(55000, 4, 2640000)]
        [InlineData(55000, 4.5, 2970000)]
        public void CalculateEstimatedHouseLoanAvailable(double monthlyIncome, double approximateMultiplier, double expectedResult)
        {
            var sut = new HousePriceCalculator();

            double actualResult = sut.CalculateEstimatedHouseLoanAvailable(monthlyIncome, approximateMultiplier);

            Assert.Equal(expectedResult, actualResult);
        }

        [Theory]
        [InlineData(124999, 2500000, 5, false)]
        [InlineData(125000, 2500000, 5, true)]
        public void DoesUserHaveRequiredDownPayment(double savings, double housePrice, double housePurchasePercentage, bool expectedResult)
        {
            var sut = new HousePriceCalculator();

            bool actualResult = sut.DoesUserHaveRequiredDownPayment(savings, housePrice, housePurchasePercentage);

            Assert.Equal(expectedResult, actualResult);
        }

    }
}
