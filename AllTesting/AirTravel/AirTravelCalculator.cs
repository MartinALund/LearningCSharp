using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravel
{
    class AirTravelCalculator : IAirTravelCalculator
    {

        double basePrice = 450;

        public double CalculateFlightPrice(int amountOfTravelers, bool requestingExtraLuggage, bool isReturnFlightIncluded)
        {

            double discountPercentage = CalculateDiscount(amountOfTravelers, isReturnFlightIncluded);

            double discount = (basePrice / 100) * discountPercentage; 

            if (requestingExtraLuggage)
                basePrice += 50;

            return basePrice - discount;
        }

        public double CalculateDiscount(int amountOfTravelers, bool isReturnFlightIncluded = false)
        {
            double discountPercentage = 0.0;

            if (amountOfTravelers > 5) discountPercentage += 5;
            else if (amountOfTravelers > 3) discountPercentage += 4;
            else if (amountOfTravelers > 1) discountPercentage += 3;

            if (isReturnFlightIncluded) discountPercentage += 5;
            return discountPercentage;
        }


    }
}
