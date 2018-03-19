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
            string text = System.IO.File.ReadAllText(@"..\..\..\website-data.txt");
            string[] dataArray = text.Split('.');
            StringBuilder builder = new StringBuilder();
            builder.Append("<section class=\"introduction-section\">\n");
            foreach (var item in dataArray)
            {
                if (item.Length > 5)
                {
                    builder.Append("\t<p>");
                    builder.Append(item.Trim() + ".");
                    builder.Append("</p>");
                    builder.Append(Environment.NewLine);
                }
            }
            builder.Append("</section>");
            Clipboard.SetText(builder.ToString());
            Console.WriteLine(builder.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Data copied to clipboard");
            Console.ResetColor();
        }
    }
}
