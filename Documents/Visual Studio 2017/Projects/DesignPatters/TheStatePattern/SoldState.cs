using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    public class SoldState : State
    {
        GumBallMachine gumballMachine;

        public SoldState(GumBallMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }
        public void InsertQuater()
        {
            Console.WriteLine("Please Wait, we are already giving you a gumball");
        }
        public void EjectQuater()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }
        public void TurnCrank()
        {
            Console.WriteLine("Turning twice does not get you another gumball!");
        }
        public void Dispense()
        {
            gumballMachine.releaseBall();
            if(gumballMachine.getCount() > 0)
            {
                gumballMachine.setState(gumballMachine.getNoQuaterState());
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs!");
                gumballMachine.setState(gumballMachine.getSoldOutState());
            }
        }
    }
}
