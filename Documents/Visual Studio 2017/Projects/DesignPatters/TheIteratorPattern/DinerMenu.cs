using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIteratorPattern
{
    public class DinerMenu : Menu
    {
        static int MAX_ITEMS = 6;
        int numberOfItems = 0;
        string[] menuItems;

        public DinerMenu()
        {
            menuItems = new string[MAX_ITEMS];
            addItems("Vegetarian BLT");
            addItems("BLT");
            addItems("Soup of the day");
            addItems("Hotdog");
            addItems("Steamed veggies and brown rice");
            addItems("Pasta");
        }

        public void addItems(string name)
        {
            if (numberOfItems > MAX_ITEMS)
                Console.WriteLine("Sorry, menu is full. Can't add items");
            else
            {
                menuItems[numberOfItems] = name;
                numberOfItems = numberOfItems + 1;
            }
        }
        public string[] getMenuItems()
        {
            return menuItems;
        }
        public Iterator createIterator()
        {
            return new DinerMenuIterator(menuItems);
        }
        public override string ToString()
        {
            return "Diner Menu";
        }
    }
}
