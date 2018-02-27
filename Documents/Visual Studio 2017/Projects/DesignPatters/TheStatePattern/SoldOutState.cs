using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    public class SoldOutState : State
    {
        GumBallMachine gumballMachine;

        public SoldOutState(GumBallMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuater()
        {
            Console.WriteLine("You cannot insert a quater, the machine is sold out.");
        }
        public void EjectQuater()
        {
            Console.WriteLine("You can't eject, you have not inserted a quater yet.");
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned but there are no gumballs.");
        }
        public void Dispense()
        {
            Console.WriteLine("No gumballs dispensed"); 
        }
    }
}
