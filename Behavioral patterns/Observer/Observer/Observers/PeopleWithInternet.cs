using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Observer.Observers
{
    class PeopleWithInternet : IObserver
    {
        public string email { get; set; }
        public PeopleWithInternet(string mail)
        {
            this.email = mail;
        }
        public void Update(string message)
        {
            Console.WriteLine("На эл. почту - {0} пришло письмо с текстом: {1}", email, message);
        }
    }
}
