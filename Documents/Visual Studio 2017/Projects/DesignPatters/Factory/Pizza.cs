using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();

        public string GetName()
        {
            return name;
        }
        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
        }
        public void Bake()
        {
            Console.WriteLine("Baking " + name);
        }
        public void Cut()
        {
            Console.WriteLine("Cutting " + name);
        }
        public void Box()
        {
            Console.WriteLine("Boxing " + name);
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
