using System;

namespace Abstract_Factory.Products.Chairs
{
    class ModernChair : Chair
    {
        public override void BuyChair()
        {
            Console.WriteLine("Куплено кресло стиля МОДЕРН");
        }
    }
}
