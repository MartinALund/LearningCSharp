using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AirTravel
{
    public class AirTravelCalculatorTests
    {

        [Theory]
        [InlineData(1, 450, false, false)]
        [InlineData(1, 500, false, true)]
        [InlineData(1, 477.5, true, true)]
        [InlineData(1, 427.5, true, false)]
        [InlineData(2, 436.5, false, false)]
        [InlineData(2, 486.5, false, true)]
        [InlineData(2, 464, true, true)]
        [InlineData(5, 432, false, false)]
        [InlineData(5, 482, false, true)]
        [InlineData(10, 427.5, false, false)]
        [InlineData(10, 405, true, false)]
        [InlineData(10, 477.5,false, true)]
        [InlineData(10, 455,true, true)]

        void CalculateFlightPriceTest(int amountOfTravelers, double expectedPrice, bool isReturnFlightIncluded, bool requestingExtraLuggage)
        {
            var sut = new AirTravelCalculator();

            double calculatedFlightPrice = sut.CalculateFlightPrice(amountOfTravelers, requestingExtraLuggage, isReturnFlightIncluded);

            Assert.Equal(expectedPrice, calculatedFlightPrice);
        }

        [Theory]
        [InlineData(2, 3)]
        [InlineData(3, 3)]
        public void Discount3Pct_WhenTwoOrThreeTravelers(int amountOfTravelers, double expectedDiscountPercentage)
        {
            var sut = new AirTravelCalculator();

            var actualDiscountPercentage = sut.CalculateDiscount(amountOfTravelers);

            Assert.Equal(expectedDiscountPercentage, actualDiscountPercentage);
        }

        [Theory]
        [InlineData(4, 4)]
        [InlineData(5, 4)]
        public void Discount4Pct_WhenFourOrFiveTravelers(int amountOfTravelers, double expectedDiscountPercentage)
        {
            var sut = new AirTravelCalculator();

            var actualDiscountPercentage = sut.CalculateDiscount(amountOfTravelers);

            Assert.Equal(expectedDiscountPercentage, actualDiscountPercentage);
        }

        [Theory]
        [InlineData(6, 5)]
        [InlineData(10, 5)]
        [InlineData(100, 5)]
        public void Discount5Pct_WhenGreaterThanFiveTravelers(int amountOfTravelers, double expectedDiscountPercentage)
        {
            var sut = new AirTravelCalculator();

            var actualDiscountPercentage = sut.CalculateDiscount(amountOfTravelers);

            Assert.Equal(expectedDiscountPercentage, actualDiscountPercentage);
        }

        [Theory]
        [InlineData(1, 0)]
        public void NoDiscount_WhenSinglePersonBooksFlight(int amountOfTravelers, double expectedDiscountPercentage)
        {
            var sut = new AirTravelCalculator();

            var actualDiscountPercentage = sut.CalculateDiscount(amountOfTravelers);

            Assert.Equal(expectedDiscountPercentage, actualDiscountPercentage);
        }

        [Theory]
        [InlineData(1, true, 5)]
        public void Discount5Pct_WhenSinglePersonBooksReturnFlight(int amountOfTravelers, bool isReturnFlightBooked, double expectedDiscountPercentage)
        {
            var sut = new AirTravelCalculator();

            var actualDiscountPercentage = sut.CalculateDiscount(amountOfTravelers, isReturnFlightBooked);

            Assert.Equal(expectedDiscountPercentage, actualDiscountPercentage);
        }

        [Theory]
        [InlineData(6,true,10)]
        [InlineData(10, true, 10)]
        [InlineData(1000,true,10)]
        public void Discount10Pct_WhenGroupOfSixOrMoreBooksReturnFlight(int amountOfTravelers, bool isReturnFlightBooked, double expectedDiscountPercentage)
        {
            var sut = new AirTravelCalculator();

            var actualDiscountPercentage = sut.CalculateDiscount(amountOfTravelers, isReturnFlightBooked);

            Assert.Equal(expectedDiscountPercentage, actualDiscountPercentage);
        }


    }
}
