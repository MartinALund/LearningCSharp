using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadFromTxt
{
    class Data
    {

        public string Filename { get; set; }
        public Data(string filename)
        {
            this.Filename = filename;
            GetAllData();
        }

        public List<CustomDateTime> GetAllData()
        {
            string[] lines = File.ReadAllLines(Filename);
            List<CustomDateTime> dates = new List<CustomDateTime>();
            foreach (string line in lines)
            {
                dates.Add(new CustomDateTime(line));
            }
            return dates;
        }

        public List<string> GetDataFromOneDay(string specificDate)
        {
            string[] lines = File.ReadAllLines(Filename);
            List<string> specificDateList = new List<string>();
            foreach (string line in lines)
            {
                if (line.Contains(specificDate))
                {
                    specificDateList.Add(line);
                }
            }
            return specificDateList;
        }

        public void GetAmountPrHour(string specificDate)
        {

            List<CustomDateTime> dates = new List<CustomDateTime>();

            foreach (string line in GetDataFromOneDay(specificDate))
            {
                dates.Add(new CustomDateTime(line));
            }
            var dictionary = new Dictionary<int, int>();

            foreach (CustomDateTime date in dates)
            {
                if (dictionary.ContainsKey(date.Hour))
                    dictionary[date.Hour]++;
                else
                    dictionary.Add(date.Hour, 1);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
           

        }
    }
}
