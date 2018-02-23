using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDeserializer
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public bool Alive { get; set; }
        public Address Address { get; set; }
        public List<PhoneNumber> PhoneNumbers { get; set; }

    }
}
