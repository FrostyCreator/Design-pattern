using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Facade
{
    class Shop
    {
        static Random random = new Random();
        public void AnswerToCall()
        {
            Console.WriteLine("Здравствуйте, вы позвонили в магазин...");
        }
        public bool ProductInStock()
        {
            return random.NextDouble() < 0.5;
        }
        public void GoToStock()
        {
            Stock stock = new Stock();
            stock.GetProduct();
            Console.WriteLine("Привезли товар со склада");
        }
        public void GetProduct()
        {
            Console.WriteLine("Продукт выдан покупателю");
        }
    }
}
