using DesignPatters.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatters.quack
{
    class Quack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I can Quack");
        }
    }
}
