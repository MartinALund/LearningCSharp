using System;
using System.Collections.Generic;
using System.Text;

namespace DeepClone
{
    class Address
    {
        public string Street { get; set; }
        public int ZIP { get; set; }
        public string City { get; set; }

        public Address(string street, int zip, string city)
        {
            this.Street = street;
            this.ZIP = zip;
            this.City = city;
        }

        public Address DeepClone()
        {
            return new Address(Street, ZIP, City);
        }

    }
}
