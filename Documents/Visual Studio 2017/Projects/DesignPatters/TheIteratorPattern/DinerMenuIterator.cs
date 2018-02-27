using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheIteratorPattern
{
    public class DinerMenuIterator : Iterator
    {
        string[] items;
        int position = 0;

        public DinerMenuIterator(string[] items)
        {
            this.items = items;
        }
        public object next()
        {
            string menuItem = items[position];
            position = position + 1;
            return menuItem;
        }
        public bool hasNext()
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }
    }
}
