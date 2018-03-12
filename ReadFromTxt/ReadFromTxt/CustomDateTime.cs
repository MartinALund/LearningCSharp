using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ReadFromTxt
{
    public class CustomDateTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hour { get; set; }
        public string Minutes { get; set; }
        public int Seconds { get; set; }

        public CustomDateTime(string input)
        {
                DateTime inputDate = DateTime.Parse(input);
                Year = inputDate.Year;
                Month = inputDate.Month;
                Day = inputDate.Day;
                Hour = inputDate.Hour;
                Minutes = inputDate.Minute.ToString("D2");
                Seconds = inputDate.Second;          
        }

        public override string ToString()
        {
            return Year + "-" + Month + "-" + Day + " " + Hour + ":" + Minutes + ":" + Seconds;
        }
    }
}
