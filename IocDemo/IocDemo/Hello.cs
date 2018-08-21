using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IocDemo
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
            return $"Hello {_medarbejder.GetNavn()}";
        }
    }

    public interface IMedarbejder
    {
        string GetNavn();
    }

    public class Medarbejder : IMedarbejder
    {
        public string GetNavn()
        {
            return "PBA student";
        }
    }
}
