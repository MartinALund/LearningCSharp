using JSONDeserializer;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace JSONDeserializer
{
    public class Deserialize
    {

        private static Deserialize instance = new Deserialize();

        private Deserialize()
        {
                
        }

        public static Deserialize GetInstance()
        {
            return instance;
        }

        public List<Person> DeserializeJSON(string JSONString, List<Person> people)
        {
            try
            {
                //GET A LIST OF PEOPLE
                people = JsonConvert.DeserializeObject<List<Person>>(JSONString);
                Console.WriteLine(people.Count);
                //GET A SINGLE PERSON WITH JSON
                //Person jPerson = JsonConvert.DeserializeObject<Person>(JSONString);

            }
            catch (Exception)
            {

                throw;
            }
            return people;
        }
    }
}
