using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravel
{
    interface IAirTravelCalculator
    {
        double CalculateFlightPrice(int amountOfTravelers, bool requestingExtraLuggage, bool isReturnFlightIncluded);
        double CalculateDiscount(int amountOfTravelers, bool isReturnFlightIncluded);
    }
}
