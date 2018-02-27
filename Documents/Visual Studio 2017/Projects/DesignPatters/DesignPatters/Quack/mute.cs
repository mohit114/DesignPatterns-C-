using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.interfaces;

namespace DesignPatters.quack
{
    class mute : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("I cannot quack");
        }
    }
}
