using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIteratorPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu dinerMenu = new DinerMenu();

            Iterator pancakeIterator = pancakeHouseMenu.createIterator();
            Iterator dinerIterator = dinerMenu.createIterator();

            Console.WriteLine("\nMenu (with iterators)\n---\nBREAKFAST");
            printMenu(pancakeIterator);

            Console.WriteLine("\nLUNCH");
            printMenu(dinerIterator);

            Console.ReadKey();
        }
        private static void printMenu(Iterator iterator)
        {
            while (iterator.hasNext())
            {
                string menuitem = (string)iterator.next();
                Console.WriteLine(menuitem);
            }
        }
    }
}
