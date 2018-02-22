using System;
using System.Collections.Generic;
using System.Text;

namespace DeepClone
{
    class Person
    {

        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public double Weight { get; set; }

        public Person(Address address, DateTime dateOfBirth, double weight)
        {
            this.Address = address;
            this.DateOfBirth = dateOfBirth;
            this.Weight = weight;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = ShallowCopy();
            other.Address = Address.DeepClone();
            return other;
        }
    }
}
