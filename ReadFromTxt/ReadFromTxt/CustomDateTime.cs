using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadFromTxt
{
    public class Datatime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public string Minutes { get; set; }
        public int Seconds { get; set; }

        public Datatime(string input)
        {
            DateTime dDate;

            if (DateTime.TryParse(input, out dDate))
            {
                DateTime inputDate = DateTime.Parse(input);
                Year = inputDate.Year;
                Month = inputDate.Month;
                Day = inputDate.Day;
                Hour = inputDate.Hour;
                Minutes = inputDate.Minute.ToString("D2");
                Seconds = inputDate.Second;
            }
            else
            {
                Console.WriteLine("Invalid date");
            }             
        }

        public override string ToString()
        {
            return Year + "-" + Month + "-" + Day + " " + Hour + ":" + Minutes + ":" + Seconds;
        }
    }
}
