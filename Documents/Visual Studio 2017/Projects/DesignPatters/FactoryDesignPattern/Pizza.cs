using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine("Prepare " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            for(int i = 0; i < toppings.Count(); i++)
            {
                Console.WriteLine("-" + toppings[i].ToString());
            }
        }
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }
        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }
        public string GetName()
        {
            return name;
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("--- " + name + " ---\n");
            builder.Append(dough + "\n");
            builder.Append(sauce + "\n");
            for (int i = 0; i < toppings.Count(); i++)
                builder.Append(toppings[i].ToString() + "\n");
            return builder.ToString();
        }

    }
}
