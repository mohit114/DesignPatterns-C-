using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        public static void Main(string[] args)
        {
            SimplePizzaFactory pizzaFactory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(pizzaFactory);

            Pizza pizza = pizzaStore.orderPizza("cheese");
            Console.WriteLine("We ordered a " + pizza.GetName() + "\n");
            Console.WriteLine(pizza.ToString());

            pizza = pizzaStore.orderPizza("pepperoni");
            Console.WriteLine("We ordered a " + pizza.GetName() + "\n");
            Console.WriteLine(pizza.ToString());

            Console.ReadKey();
        }
    }
}
