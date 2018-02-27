using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NewYorkStyleCheesePizza : Pizza
    {
        public NewYorkStyleCheesePizza()
        {
            name = "NY style sauce and cheese pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
