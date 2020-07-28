using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observers
{
    interface IObserver
    {
        void Update(string message);
    }
}
