using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NewYorkStyleChickenPizza : Pizza
    {
        public NewYorkStyleChickenPizza()
        {
            name = "NewYork Style Chicken Pizza";
            dough = "Soft Crust Dough";
            sauce = "Light Tomato Ketchup Sauce";
            toppings.Add("Extra Cheese");
            toppings.Add("Roasted Almonds");
        }
    }
}
