using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza()
        {
            name = "Pepperoni Pizza";
            dough = "Crust";
            sauce = "Tomato Sauce";
            toppings.Add("Shredded mozzarella");
            toppings.Add("Grated Parmesan");
            toppings.Add("Diced Onion");
            toppings.Add("Sliced mushrooms");
            toppings.Add("Sliced red pepper");
            toppings.Add("Sliced black olives");
        }
    }
}
