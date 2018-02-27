using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheObserverPattern
{
    public interface IObserver
    {
        //method called by the subject when it needs to notify observer of a change
        void Update(float temp, float humidity, float pressure);
    }
}
