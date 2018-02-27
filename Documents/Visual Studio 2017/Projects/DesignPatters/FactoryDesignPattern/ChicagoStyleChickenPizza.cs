using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ChicagoStyleChickenPizza : Pizza
    {

        public ChicagoStyleChickenPizza()
        {
            name = "Chicago Style Chicken Pizza";
            dough = "Hard Crust Dough";
            sauce = "Tomato Sauce";
            toppings.Add("Mushroom");
            toppings.Add("Roasted Onions");
            toppings.Add("Pineapple");
            toppings.Add("Roasted Ginger");
        }
        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
