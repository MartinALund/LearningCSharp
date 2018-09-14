using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkdll
{
    public class ParkingLot
    {
        private List<Car> carsInParkingLot;

        public ParkingLot()
        {
            carsInParkingLot = new List<Car>();
        }

        public void EnterParkingLot(Car car)
        {
            foreach (var carInLot in carsInParkingLot)
            {
                if (!carInLot.RegNr.Equals(car.RegNr)) continue;
                else throw new Exception("Duplicate registration number");
            }
            carsInParkingLot.Add(car);
        }

        public void LeaveParkingLot(Car car)
        {
            for (var i = 0; i < carsInParkingLot.Count; i++)
            {
                if (!carsInParkingLot[i].RegNr.Equals(car.RegNr)) continue;
                carsInParkingLot.RemoveAt(i);
                return;
            }
            throw new Exception("Car is not parked in parking lot");
        }

        public IReadOnlyList<Car> GetAllCars()
        {
            return carsInParkingLot;
        }

        public Car GetCar(Car car)
        {
            Car carInLot = carsInParkingLot.Find(x => x == car);
            if (carInLot != null) return carInLot;
            else throw new NullReferenceException("Car is not parked in parking lot");
        }
    }
}
