using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class ChicagoStylePizza : PizzaStore
    {
        public override Pizza CreatePizza(string item)
        {
            if (item.Equals("cheese"))
                return new ChicagoStyleCheesePizza();
            else if (item.Equals("chicken"))
                return new ChicagoStyleChickenPizza();
            else return null;
        }
    }
}
