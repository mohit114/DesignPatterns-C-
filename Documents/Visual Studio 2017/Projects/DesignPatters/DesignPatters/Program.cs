using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters;
using DesignPatters.Ducks;
using DesignPatters.Fly;

namespace DesignPatters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the first application of design patterns");
            MallardDuck duck = new MallardDuck();
            duck.PerformFly();
            duck.PerformQuack();
            duck.Swim();
            duck.SetFlyBehaviour(new FlyNoWay());
            duck.PerformFly();
            Console.ReadKey();
        }
    }
}
