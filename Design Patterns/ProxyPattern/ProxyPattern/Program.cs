using System;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize == Loading image + displaying
            IImage image = new ProxyImage("test.jpg");
            image.Display();

            //Already loaded
            image.Display();

            // New image with initialization == Loading image + displaying.
            IImage image2 = new ProxyImage("test2.jpg");
            image2.Display();
            Console.ReadKey();
        }
    }
}
