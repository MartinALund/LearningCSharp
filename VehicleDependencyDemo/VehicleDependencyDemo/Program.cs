using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;

namespace VehicleDependencyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            RegisterTypes(container);     
            container.RegisterType<IVehicle, Car>();
            var vehicle = container.Resolve<VehicleController>();
            vehicle.Accelerate();
            vehicle.Brake();
            Console.ReadKey();

        }

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterTypes(
                AllClasses.FromLoadedAssemblies(),
                WithMappings.FromMatchingInterface,
                WithName.Default);
        }
    }
}
