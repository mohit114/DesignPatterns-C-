using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.interfaces;

namespace DesignPatters.Fly
{
    class FlyNoWay : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I cannot fly");
        }
    }
}
