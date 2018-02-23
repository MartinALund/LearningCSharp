using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSONDeserializer
{
    class Program
    {
        string json = @"[{
  'firstname':'Martin',
  'lastname':'Lund',
  'age': 26,
  'alive': true,
  'address':{
    'street':'Sted1',
    'city': 'Odense SØ',
    'zip': '5220'
  },
  'phonenumbers': [
    {'type' : 'home', 'number' : '65301241'},
    {'type' : 'mobile', 'number' : '87654321'}
  ]
},
{
  'firstname':'Jens',
  'lastname':'Lyn',
  'age': 52,
  'alive': true,
  'address':{
    'street':'Somewhere',
    'city': 'Nyborg',
    'zip': '5800'
  },
  'phonenumbers': [
    {'type' : 'home', 'number' : '65304312'},
    {'type' : 'mobile', 'number' : '12345678'}
  ]
}
]";
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Run();

        }

        public void Run()
        {
            List<Person> people = new List<Person>();
            people = Deserialize.GetInstance().DeserializeJSON(json, people);

            Console.WriteLine(people.Count);
            foreach (Person person in people)
            {
                Console.WriteLine("First name: " + person.Firstname);
                Console.WriteLine("Address: " + person.Address.Street);

                foreach (var num in person.PhoneNumbers)
                {
                    Console.WriteLine(num.Type + " : " + num.Number);
                }
            }
            Console.ReadKey();
        }
    }
}
