using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingWithRouting
{
    [Serializable]
    public class AnotherPerson
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return "AnotherPerson Name: " + Name + " " + " age: " + Age;
        }
    }
}
