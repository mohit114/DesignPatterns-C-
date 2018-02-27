using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    public class GumBallMachine
    {
        State soldOutState;
        State noQuaterState;
        State hasQuaterState;
        State soldState;

        State state;
        int count = 0;

        public GumBallMachine(int numberGumballs)
        {
            
            soldOutState = new SoldOutState(this);
            noQuaterState = new NoQuaterState(this);
            hasQuaterState = new HasQuaterState(this);
            soldState = new SoldState(this);
            state = soldOutState;
            this.count = numberGumballs;
            if(numberGumballs > 0)
            {
                state = noQuaterState;
            }
        }

        public void insertQuater()
        {
            state.InsertQuater();
        }
        public void ejectQuater()
        {
            state.EjectQuater();
        }
        public void turnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
                count = count - 1;
        }

        public int getCount()
        {
            return count;
        }
        
        public void refill(int count)
        {
            this.count = count;
            state = noQuaterState;
        }
        public void setState(State state)
        {
            this.state = state;
        }
        public State getSoldOutState()
        {
            return soldOutState;
        }
        public State getNoQuaterState()
        {
            return noQuaterState;
        }
        public State getHasQuaterState()
        {
            return hasQuaterState;
        }
        public State getSoldState()
        {
            return soldState;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("\nMighty Gumball, Inc.");
            result.Append("\n.NET-enabled Standing Gumball Model #2017");
            result.Append("\nInventory: " + count.ToString() + " gumball");
            return result.ToString();
        }
    }
}
