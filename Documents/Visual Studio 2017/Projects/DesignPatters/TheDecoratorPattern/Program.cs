using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.Cost());

            Beverage beverage1 = new HouseBlend();
            beverage1 = new Whip(beverage1);
            beverage1 = new Soy(beverage1);
            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());

            Beverage beverage2 = new StarBuzzCoffee();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Milk(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Console.ReadKey();
        }
    }
}
