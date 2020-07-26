using System;

namespace Abstract_Factory.Products.Tables
{
    class ModernTable : Table
    {
        public override void BuyTable()
        {
            Console.WriteLine("Куплен столик стиля МОДЕРН");
        }
    }
}
