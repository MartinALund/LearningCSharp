using System;
using System.Collections.Generic;
using System.IO;

namespace ReadFromTxt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\the_t\Desktop\Projekter\LearningCSharp\ReadFromTxt\ReadFromTxt\data.txt");
            List<CustomDateTime> dates = new List<CustomDateTime>();
            foreach (string line in lines)
            {
                CustomDateTime datatime = new CustomDateTime(line);
                dates.Add(datatime);
            }
            foreach (CustomDateTime date in dates)
            {
                Console.WriteLine(date.ToString());
            }
            Console.ReadKey();
        }
    }
}
