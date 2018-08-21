using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo
{
    public class Hello : IHello
    {
        private readonly IMedarbejder _medarbejder;

        public Hello(IMedarbejder medarbejder)
        {
            _medarbejder = medarbejder;
        }
        public string SayHello()
        {
            return $"Hello {_medarbejder.GetName()} ";
        }
    }
}
