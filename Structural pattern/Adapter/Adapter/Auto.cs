using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
