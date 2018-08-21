using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleDependencyDemo
{

    public class VehicleController
    {
        private readonly IVehicle _vehicle;

        public VehicleController(IVehicle vehicle) => _vehicle = vehicle;

        public void Accelerate() => _vehicle.Accelerate();

        public void Brake() => _vehicle.Brake();
    }

    public interface IVehicle
    {
        void Accelerate();
        void Brake();
    }

    public class Truck : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Truck accelerates...");
        }

        public void Brake()
        {
            Console.WriteLine("Truck brakes...");
        }
    }

    public class Car : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Car accelerates...");
        }

        public void Brake()
        {
            Console.WriteLine("Car brakes...");
        }
    }

}
