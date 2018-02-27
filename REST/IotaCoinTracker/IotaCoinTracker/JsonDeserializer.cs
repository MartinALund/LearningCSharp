using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace IotaCoinTracker
{
    public class JsonDeserializer
    {
        public List<Coin> DeserializeJSON(string JSONString, List<Coin> coins)
        {
            try
            {
                coins = JsonConvert.DeserializeObject<List<Coin>>(JSONString);
            }
            catch (Exception e)
            {
                Console.WriteLine("Mønten blev ikke fundet! Prøv igen");
            }
            return coins;
        }
    }
}
