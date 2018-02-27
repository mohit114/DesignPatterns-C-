using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{ 
    //all the display class will implement
    public interface IDisplayElement
    {
        //call this method to get the weather information from the main class
        void Display();
    }
}
