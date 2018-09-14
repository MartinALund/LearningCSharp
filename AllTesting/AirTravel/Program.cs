using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTravel
{
    class Program
    {
        static void Main(string[] args)
        {

            AirTravelCalculator atc = new AirTravelCalculator();

            Console.WriteLine("Antal personer der skal afsted");
            int amountOfTravelers = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Baggage? true/false");
            bool requiresExtraLuggage = bool.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Return flight? true/false");
            bool requiresReturnFlight = bool.Parse(Console.ReadLine());
            Console.Clear();

            double calculatedPrice = atc.CalculateFlightPrice(amountOfTravelers, requiresExtraLuggage, requiresReturnFlight);
            Console.WriteLine($"Calculated price for your trip comes down to {calculatedPrice} DKK!");
            Console.ReadLine();
        }
    }
}
