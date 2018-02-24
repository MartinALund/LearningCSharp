using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleSpreadsheetAPI
{
    class Program
    {
        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        string spreadsheetId = "13Cf5L5s5HGmkP7QhUPkV12sUTYkAO0V7uGdU2ToiNWc";


        static void Main(string[] args)
        {         
            Program program = new Program();
            program.Run();
        }

        public void Run()
        {
            var service = EstablishConnection();
            // Define request parameters. 
            string shoppingRange = "Shoppe!A2:B";
            string foodPlanRange = "Ugeplan!A2:B";

            IList<IList<Object>> shoppingList = GetValues(shoppingRange, service);
            IList<IList<Object>> foodPlanList = GetValues(foodPlanRange, service);

            while (true)
            {
                Console.WriteLine("1. Print shopping liste");
                Console.WriteLine("2. Print ugeplan");
                int menuSelection = int.Parse(Console.ReadLine());
                switch (menuSelection)
                {
                    case 1:
                        PrintList(shoppingList, "Produkt", "Antal");
                        break;
                    case 2:
                        PrintList(foodPlanList, "Ugedag", "Menu");
                        break;
                }
                Console.WriteLine("Tryk på en vilkårlig tast for at komme tilbage");
                Console.ReadKey();
                Console.Clear();
            }

          
        }

        public void PrintList(IList<IList<Object>> list, string columnA, string columnB)
        {
            if (list != null && list.Count > 0)
            {
                Console.WriteLine(columnA + " - " + columnB);
                foreach (var row in list)
                {
                    // Print columns A and B, which correspond to indices 0 and 1.
                    Console.WriteLine("{0} -  {1} ", row[0], row[1]);
                }
            }
            else
            {
                Console.WriteLine("No data found.");
            }
        }

        public IList<IList<Object>> GetValues(string Range, dynamic service)
        {          
            SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, Range);

            ValueRange response = request.Execute();
            return response.Values;
        }

        public dynamic EstablishConnection()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            return service;
        }
    }
}
