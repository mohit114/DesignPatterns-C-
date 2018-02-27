using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSingletonPattern
{
    public class Singleton
    {
        private static Singleton uniqueSingleton = new Singleton(); //making thread safe. If set to null and created instance in GetInstance method, multiple threads can create multiple instances. In java you can add synchronized key word in GetInstance Method to make thread safe.

        private Singleton() { }

        public static Singleton GetInstance()
        {
            return uniqueSingleton;
        }
        public void DisplayMessage()
        {
            Console.WriteLine("Hello i am a singleton class");
        }
    }
}
