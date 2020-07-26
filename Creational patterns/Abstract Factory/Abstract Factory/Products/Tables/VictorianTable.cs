using System;

namespace Abstract_Factory.Products.Tables
{
    class VictorianTable : Table
    {
        public override void BuyTable()
        {
            Console.WriteLine("Куплен столик ВИКТОРИАНСКОГО стиля");
        }
    }
}
