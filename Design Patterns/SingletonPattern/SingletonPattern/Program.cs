using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // This will not work since the constructor is private
            // SingleObject singleObject = new SingleObject();

            SingleObject.GetInstance().ShowMessage();
            Console.ReadKey();
        }
    }
}
