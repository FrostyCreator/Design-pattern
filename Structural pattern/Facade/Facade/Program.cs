using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            SupportService service = new SupportService();
            service.TakeOrder();
        }
    }
}
