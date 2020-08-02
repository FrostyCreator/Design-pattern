using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    class SupportService
    {
        static Shop shop = new Shop();
        public void TakeOrder()
        {
            shop.AnswerToCall();
            if (shop.ProductInStock())
            {
                shop.GetProduct();
            }
            else
            {
                shop.GoToStock();
                shop.GetProduct();
            }
        }
    }
}
