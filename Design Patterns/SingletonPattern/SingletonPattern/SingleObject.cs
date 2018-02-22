using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class SingleObject
    {
        //Object of SingleObject
        private static SingleObject instance = new SingleObject();

        //Constructor private - Class can't be instantiated
        private SingleObject() { }

        // Get the object available
        public static SingleObject GetInstance()
        {
            return instance;
        }

        public void ShowMessage()
        {
            Console.WriteLine("You got the object");
        }
    }
}
