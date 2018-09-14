using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SmartParkdll;

namespace SmartParkConsole
{
    class Program
    {
        private List<Car> testCars = new List<Car>
            {
                new Car("AB12313"),
                new Car("EB12351"),
                new Car("UG97658"),
                new Car("YG65334"),
                new Car("AD16996"),
                new Car("SY79634"),
                new Car("OK69123"),
                new Car("TA64156"),
                new Car("DA59211"),
                new Car("XX06451")
            };

        static void Main(string[] args)
        {
            var myProgram = new Program();
            myProgram.Run();
        }

        private void Run()
        {
            var parkingLot = new ParkingLot();
            var random = new Random();

            while (true)
            {
                foreach (var car in testCars)
                {
                    var actor = new Actor(parkingLot, car, random.Next(2000,9000));
                    var thread = new Thread(actor.Run);
                    thread.Start();
                    Thread.Sleep(1500);
                }
            }
        }
    }
}

