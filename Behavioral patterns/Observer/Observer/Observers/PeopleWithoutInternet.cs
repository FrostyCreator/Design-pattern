using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Observers
{
    class PeopleWithoutInternet : IObserver
    {
        public string PhoneNumber { get; set; }

        public PeopleWithoutInternet(string phoneNumber)
        {
            PhoneNumber = phoneNumber;
        }

        public void Update(string message)
        {
            Console.WriteLine("на телефонный номер - {0} пришло СМС с текстом: {1}",PhoneNumber, message);
        }
    }
}
