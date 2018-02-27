using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class NewYorkStylePizza : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
                return new NewYorkStyleCheesePizza();
            else if (item.Equals("chicken"))
                return new NewYorkStyleChickenPizza();
            else return null;
        }
    }
}
