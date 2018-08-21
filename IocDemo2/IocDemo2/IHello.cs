using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDemo2
{
    public interface IHello
    {
        string SayHello();
    }

    public class Hello : IHello
    {
        private readonly IMedarbejder _medarbejder;

        public Hello(IMedarbejder medarbejder)
        {
            _medarbejder = medarbejder;
        }
        public string SayHello()
        {
            return $"Hello {_medarbejder.GetName()}";
        }
    }

    public interface IMedarbejder
    {
        string GetName();
    }

    public class Medarbejder : IMedarbejder
    {
        public string GetName()
        {
            return "Martin";
        }
    }
}
