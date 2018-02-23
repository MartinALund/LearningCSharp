using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class ProxyImage : IImage
    {
        private RealImage realImage;
        private string filename;

        public ProxyImage(string filename)
        {
            this.filename = filename;
        }


        public void Display()
        {
            if (realImage == null)
                realImage = new RealImage(filename);
            realImage.Display();
        }
    }
}
