using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartParkdll
{
    public class Car
    {
        public string RegNr { get; set; }

        public Car(string regNr)
        {
            RegNr = regNr;
        }
    }
}
