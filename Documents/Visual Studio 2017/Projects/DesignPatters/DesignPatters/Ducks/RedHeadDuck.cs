using DesignPatters.Fly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.quack;

namespace DesignPatters.Ducks
{
    class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("I am a red head duck");
        }
    }
}
