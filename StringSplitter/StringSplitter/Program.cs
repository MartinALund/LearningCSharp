using System;
using System.Text;
using System.Windows;

namespace StringSplitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "String splitter. På punktum. Hver paragraph bliver indskudt i et <p> tag.";
            string[] dataArray = data.Split(".");
            StringBuilder builder = new StringBuilder();
            foreach (var item in dataArray)
            {
                if (item.Length > 1)
                {
                    builder.Append("<p>");
                    builder.Append(item.Trim() + ".");
                    builder.Append("</p>");
                    builder.Append(Environment.NewLine);
                }
            }
            Console.WriteLine(builder.ToString());           
        }
    }
}
