using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "Cheese Pizza";
            dough = "Regular Crust";
            sauce = "Marinari Pizza Sauce";
            toppings.Add("Fresh Mozzarella");
            toppings.Add("Parmesan");
        }
    }
}
