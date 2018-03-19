using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringSplitter
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string data = "String splitter. På punktum. Hver paragraph bliver indskudt i et <p> tag.";
            string[] dataArray = data.Split('.');
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
            Clipboard.SetText(builder.ToString());
            Console.WriteLine(builder.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Data copied to clipboard");
            Console.ResetColor();
        }
    }
}
