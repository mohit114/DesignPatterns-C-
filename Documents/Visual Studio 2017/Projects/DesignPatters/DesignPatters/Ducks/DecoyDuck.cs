using DesignPatters.Fly;
using DesignPatters.quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.Ducks
{
    class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new mute();
        }
        public override void Display()
        {
            Console.WriteLine("I am a decoy duck");
        }
    }
}
