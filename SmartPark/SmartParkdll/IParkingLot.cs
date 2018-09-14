using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkdll
{
    interface IParkingLot
    {
        void LeaveParkingLot(Car car);
        void EnterParkingLot(Car car);
        Car GetCar(Car car);
        IReadOnlyList<Car> GetAllCars();
    }
}
