using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheStatePattern
{
    public interface State
    {
        void InsertQuater();
        void EjectQuater();
        void TurnCrank();
        void Dispense();
    }
}
