using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    public class HasQuaterState : State
    {
        GumBallMachine gumballMachine;

        public HasQuaterState(GumBallMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuater()
        {
            Console.WriteLine("You cannot insert another quater");
        }
        public void EjectQuater()
        {
            Console.WriteLine("Quater returned");
            gumballMachine.setState(gumballMachine.getNoQuaterState());
        }
        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            gumballMachine.setState(gumballMachine.getSoldState());
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
