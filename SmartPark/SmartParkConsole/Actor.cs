using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartParkdll;

namespace SmartParkConsole
{
    public class Actor
    {
        private int sleep;
        private ParkingLot parkingLot;
        private Car car;

        public Actor(ParkingLot parkingLot, Car car, int sleep)
        {
            this.sleep = sleep;
            this.parkingLot = parkingLot;
            this.car = car;
        }

        public void Run()
        {
            Random random = new Random();
            lock (parkingLot)
            {
                parkingLot.EnterParkingLot(car);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Car enter, reg:{car.RegNr} - Cars in parking lot: {parkingLot.GetAllCars().Count}");
            }
            System.Threading.Thread.Sleep(sleep);
            lock (parkingLot)
            {
                parkingLot.LeaveParkingLot(car);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Car leave, reg:{car.RegNr} - Cars in parking lot: {parkingLot.GetAllCars().Count}");
            }
            lock (parkingLot)
            {
                if(random.Next(0,10) == 5)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Person at info desk!");
                    Console.WriteLine("--------------------------------");
                    foreach (var item in parkingLot.GetAllCars())
                    {
                        Console.WriteLine($"Car parked: {item.RegNr}");
                    }
                    Console.WriteLine($"Total amount of cars: {parkingLot.GetAllCars().Count}");
                    Console.WriteLine("--------------------------------");

                }
            }
        }
    }
}
