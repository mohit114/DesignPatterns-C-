using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDecoratorPattern
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }
        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
        public override double Cost()
        {
            return .10 + beverage.Cost();
        }
    }
}
