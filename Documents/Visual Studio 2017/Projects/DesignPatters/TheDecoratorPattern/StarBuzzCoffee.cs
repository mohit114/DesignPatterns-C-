using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDecoratorPattern
{
    public class StarBuzzCoffee : Beverage
    {
        public StarBuzzCoffee()
        {
            description = "Star Buzz Coffee";
        }
        public override double Cost()
        {
            return 2.99;
        }
    }
}
