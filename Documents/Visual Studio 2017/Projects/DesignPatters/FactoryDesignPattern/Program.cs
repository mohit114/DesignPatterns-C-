using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore NYStore = new NewYorkStylePizza();
            PizzaStore ChicagoStore = new ChicagoStylePizza();

            Pizza pizza = NYStore.OrderPizza("cheese");
            Console.WriteLine(pizza.ToString());
            Console.WriteLine("Mohit ordered a " + pizza.GetName() + "\n");


            pizza = ChicagoStore.OrderPizza("cheese");
            Console.WriteLine(pizza.ToString());
            Console.WriteLine("Niru ordered a " + pizza.GetName() + "\n");

            pizza = ChicagoStore.OrderPizza("chicken");
            Console.WriteLine(pizza.ToString());
            Console.WriteLine("Vihaan ordered a " + pizza.GetName() + "\n");

            pizza = NYStore.OrderPizza("chicken");
            Console.WriteLine(pizza.ToString());
            Console.WriteLine("Shankar ordered a " + pizza.GetName() + "\n");

            Console.ReadKey();
        }
    }
}
