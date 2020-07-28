using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observable
{
    interface IObservable
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver o);
        void NotifyObservers(string message);
    }
}
