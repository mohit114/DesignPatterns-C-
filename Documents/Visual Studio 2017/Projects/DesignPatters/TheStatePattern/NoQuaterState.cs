using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    public class NoQuaterState : State
    {
        GumBallMachine gumballMachine;

        public NoQuaterState(GumBallMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine; 
        }
        public void InsertQuater()
        {
            Console.WriteLine("You inserted a quater");
            gumballMachine.setState(gumballMachine.getHasQuaterState());
        }
        public void EjectQuater()
        {
            Console.WriteLine("You have not inserted a quater");
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quater");
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
