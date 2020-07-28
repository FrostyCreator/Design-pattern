using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // Receiver - Получатель
    class Chef
    {
        public void Cook(string dish)
        {
            Console.WriteLine($"{dish} готово");
        }
        public void AbortCooking()
        {
            Console.WriteLine("Заказ отменён");
        }
    }
}
