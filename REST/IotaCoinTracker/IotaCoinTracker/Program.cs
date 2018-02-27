using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Xml;

namespace IotaCoinTracker
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();

        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Enter name of coin: ");
                Console.WriteLine("Enter all to display every coin available");

                string coinType = Console.ReadLine().ToLower();

                RestClient client = new RestClient("https://api.coinmarketcap.com/v1/ticker");
                RestRequest request = new RestRequest(Method.GET);
                //https://api.coinmarketcap.com/v1/ticker - alm api
                //https://api.coinmarketcap.com/v1/ticker/{cointype}/ - ny api med parameter
                //https://api.coinmarketcap.com/v1/ticker/iota - eksempel

                if (!coinType.Equals("all"))
                {

                    request.Resource = "/{coinType}/";
                    request.AddParameter("coinType", coinType, ParameterType.UrlSegment);
                }

                var response = client.Execute(request);
                string json = response.Content;
                PrintCoinInfo(json);
            }

        }

        public void PrintCoinInfo(string json)
        {
            List<Coin> coins = GetCoins(json);
            foreach (Coin coin in coins)
            {
                Console.WriteLine();
                Console.WriteLine("Id: " + coin.Id);
                Console.WriteLine("Name : " + coin.Name);
                Console.WriteLine("Symbol: " + coin.Symbol);
                Console.WriteLine("Rank: " + coin.Rank);
                Console.WriteLine("Price_USD : " + coin.Price_USD + " $");               
                Console.WriteLine(coin.ToString());
            }
            Console.ReadLine();
        }

        public List<Coin> GetCoins(string jsonString)
        {
            List<Coin> coins = new List<Coin>();
            JsonDeserializer jsonDeserializer = new JsonDeserializer();
            coins = jsonDeserializer.DeserializeJSON(jsonString, coins);
            return coins;
        }
    }
}
