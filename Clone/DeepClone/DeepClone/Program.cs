using System;

namespace DeepClone
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(new Address("1 Address", 5000, "Odense"), DateTime.Now, 80f);
            Person p2 = p1.ShallowCopy();
            Person p3 = p1.DeepCopy();

            Console.WriteLine("p1 Address: {0}", p1.Address.Street);
            Console.WriteLine("p2 Address: {0}", p2.Address.Street);
            Console.WriteLine("p3 Address: {0}", p3.Address.Street);

            p1.Address.Street = "2 Address";
            Console.WriteLine();

            Console.WriteLine("p1 Address: {0}", p1.Address.Street);
            Console.WriteLine("p2 Address: {0}", p2.Address.Street);
            Console.WriteLine("p3 Address: {0}", p3.Address.Street);

            Console.ReadLine();
        }
    }
}

