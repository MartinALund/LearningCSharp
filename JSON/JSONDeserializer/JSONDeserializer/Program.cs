using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace JSONDeserializer
{
    class Program
    {
        static void Main(string[] args)
        {

            Program program = new Program();
            program.Run();

        }

        public void Run()
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

            DeserializeJSON(json);
        }

        private void DeserializeJSON(string JSONString)
        {
            try
            {
                //GET A LIST OF PEOPLE
                List<Person> people = JsonConvert.DeserializeObject<List<Person>>(JSONString);
                foreach (Person person in people)
                {
                    Console.WriteLine("First name: " + person.Firstname);
                    Console.WriteLine("Address: " + person.Address.Street);

                    foreach (var num in person.PhoneNumbers)
                    {
                        Console.WriteLine(num.Type + " : " + num.Number);
                    }
                }
                //GET A SINGLE PERSON WITH JSON
                //Person jPerson = JsonConvert.DeserializeObject<Person>(JSONString);

            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }
    }
}
