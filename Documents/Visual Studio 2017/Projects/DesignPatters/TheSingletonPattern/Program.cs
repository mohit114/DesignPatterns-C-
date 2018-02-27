using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheSingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singletonObject = Singleton.GetInstance();
            singletonObject.DisplayMessage();
            Console.ReadKey();
        }
    }
}
