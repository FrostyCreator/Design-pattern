using Abstract_Factory.Products.Chairs;
using Abstract_Factory.Products.Tables;

namespace Abstract_Factory.FurnitureFactory
{
    class ModernFurnitureFactiry : Factory
    {
        public override Chair CreateChair()
        {
            return new ModernChair();
        }

        public override Table CreateTable()
        {
            return new ModernTable();
        }
    }
}
