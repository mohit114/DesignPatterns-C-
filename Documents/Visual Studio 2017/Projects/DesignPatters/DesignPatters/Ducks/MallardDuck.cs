using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.interfaces;
using DesignPatters.Fly;
using DesignPatters.quack;

namespace DesignPatters.Ducks
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehaviour = new FlyWithWings();
            quackBehaviour = new Quack();
        }
        public override void Display()
        {
            Console.WriteLine("I am a mallard duck");
        }
    }
}
