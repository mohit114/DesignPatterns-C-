using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIteratorPattern
{
    public class PancakeHouseMenu : Menu
    {
        List<string> menuItems;
        public PancakeHouseMenu()
        {
            menuItems = new List<string>();
            addItems("PanCake Breakfast");
            addItems("Regular PanCake Breakfast");
            addItems("Blueberry PanCake Breakfast");
            addItems("Waffles");
        }
        public void addItems(string name)
        {
            menuItems.Add(name);
        }
        public List<string> getMenuItems()
        {
            return menuItems;
        }
        public Iterator createIterator()
        {
            return new PancakeHouseMenuIterator(menuItems);
        }
        public override string ToString()
        {
            return "PanCake House Menu";
        }
    }
}
