using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string pizzaType) //code will be complex if we want another style pizza, i.e one is chicago style and another one is amasterdam style so use factory method pattern
        {
            Pizza pizza = null;
            if (pizzaType.Equals("cheese"))
                pizza = new CheesePizza();
            else if (pizzaType.Equals("pepperoni"))
                pizza = new PepperoniPizza();
            return pizza;
        }
    }
}
