using System;

namespace Abstract_Factory.Products.Chairs
{
    class VictorianChair : Chair
    {
        public override void BuyChair()
        {
            Console.WriteLine("Куплено кресло ВИКТОРИАНСКОГО стиля");
        }
    }
}
