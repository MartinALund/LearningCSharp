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
            Console.WriteLine("Please make a selection");
            Console.WriteLine("1. Bitcoin");
            Console.WriteLine("2. Ethereum");
            Console.WriteLine("3. Iota");
            Console.WriteLine("4. Litecoin");
            int selection = int.Parse(Console.ReadLine());
            RestClient client = new RestClient("https://api.coinmarketcap.com/v1/ticker");
            RestRequest request = new RestRequest( Method.GET);
            string coinType = "";
            switch (selection)
            {
                case 1:
                    coinType = "bitcoin";
                    request.Resource = "/{coinType}/";
                    request.AddParameter("coinType", coinType, ParameterType.UrlSegment);
                    break;
                case 2:
                    coinType = "ethereum";
                    request.Resource = "/{coinType}/";
                    request.AddParameter("coinType", coinType, ParameterType.UrlSegment);
                    break;
                case 3:
                    coinType = "iota";
                    request.Resource = "/{coinType}/";
                    request.AddParameter("coinType", coinType, ParameterType.UrlSegment);
                    break;
                case 4:
                    coinType = "litecoin";
                    request.Resource = "/{coinType}/";
                    request.AddParameter("coinType", coinType, ParameterType.UrlSegment);
                    break;
                default:
                    coinType = "";
                    break;
            }
            //https://api.coinmarketcap.com/v1/ticker - alm api
            //https://api.coinmarketcap.com/v1/ticker/{cointype}/ - ny api med parameter
            //https://api.coinmarketcap.com/v1/ticker/iota - eksempel

            var response = client.Execute(request);       
            string json = response.Content;
            PrintCoinInfo(json);
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
