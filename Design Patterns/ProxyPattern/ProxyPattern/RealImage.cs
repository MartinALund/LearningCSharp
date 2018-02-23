using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class RealImage : IImage
    {

        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;
            LoadFromDisk(filename);
        }

        public void Display()
        {
            Console.WriteLine("Displaying: " + filename);
        }

        private void LoadFromDisk(string filename)
        {
            Console.WriteLine("Loading: " + filename);
        }
    }
}
