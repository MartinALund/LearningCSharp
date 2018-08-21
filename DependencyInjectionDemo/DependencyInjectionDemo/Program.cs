using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.RegistrationByConvention;

namespace DependencyInjectionDemo
{
    class Program
    {

        static void Main(string[] args)
        {
            var container = new UnityContainer();
            RegisterTypes(container);

            var hello = container.Resolve<IHello>();
            Console.WriteLine(hello.SayHello());

            var order = container.Resolve<IOrder>();
            Console.WriteLine(order.PrintOrder());
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
