using Observer.Observers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observable
{
    class NewsPortal : IObservable
    {
        List<IObserver> observers;

        public NewsPortal()
        {
            this.observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this.observers.Remove(observer);
        }
        public void NotifyObservers(string message)
        {
            foreach (var observer in observers)
            {
                if (observer is PeopleWithInternet)
                    observer.Update(message);
                else
                    observer.Update("На сайте news.com вышла новая новость");
            }
        }
        public void AddNews(string news)
        {
            NotifyObservers(news);
        }
    }
}
