using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.Fly;
using DesignPatters.quack;

namespace DesignPatters.Ducks
{
    class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I am a rubber duck");
        }
    }
}
