using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatters.interfaces;

namespace DesignPatters
{
    public abstract class Duck
    {
       public IFlyBehaviour flyBehaviour;
       public IQuackBehaviour quackBehaviour;

        public abstract void Display();

        //used when we need to override fly behaviour of any duck
        public void SetFlyBehaviour(IFlyBehaviour iflyBehaviour)
        {
            this.flyBehaviour = iflyBehaviour;
        }

        //used when we need to override quack behaviour of any duck
        public void SetQuackBehaviour(IQuackBehaviour iquackBehaviour)
        {
            this.quackBehaviour = iquackBehaviour;
        }

        public void PerformFly()
        {
            flyBehaviour.fly();
        }

        public void PerformQuack()
        {
            quackBehaviour.quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks can swim including the decoy");
        }

    }
}
