using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFromTxt
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            string path = @"C:\Users\the_t\Desktop\Projekter\LearningCSharp\ReadFromTxt\ReadFromTxt\data.txt";
            Data data = new Data(path);
            data.GetAllData();

            foreach (var item in data.GetDataFromOneDay("2017-06-01"))
            {
                Console.WriteLine(item);
            }

            data.GetAmountPrHour("2017-03-01");
            Console.ReadKey();
        }

    }
}
