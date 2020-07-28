using Observer.Observable;
using Observer.Observers;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            NewsPortal portal = new NewsPortal();
            portal.RegisterObserver(new PeopleWithInternet("jora@gmail.com"));
            portal.RegisterObserver(new PeopleWithInternet("vasya@gmail.com"));
            portal.RegisterObserver(new PeopleWithoutInternet("+7894561564"));
            portal.RegisterObserver(new PeopleWithoutInternet("+7465123549"));

            portal.AddNews("новость 1");
            portal.AddNews("новость 2");
        }
    }
}
