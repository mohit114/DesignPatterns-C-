using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GumBallMachine gumballMachine = new GumBallMachine(4);
            Console.WriteLine(gumballMachine);
            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.insertQuater();
            gumballMachine.turnCrank();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine);
            gumballMachine.insertQuater();
            gumballMachine.ejectQuater();
            gumballMachine.turnCrank();
            Console.WriteLine(gumballMachine);
            Console.ReadKey();
        }
    }
}
