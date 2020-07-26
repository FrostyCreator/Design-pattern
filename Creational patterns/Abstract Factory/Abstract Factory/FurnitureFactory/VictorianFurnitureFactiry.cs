using Abstract_Factory.Products.Chairs;
using Abstract_Factory.Products.Tables;

namespace Abstract_Factory.FurnitureFactory
{
    class VictorianFurnitureFactiry : Factory
    {
        public override Chair CreateChair()
        {
            return new VictorianChair();
        }

        public override Table CreateTable()
        {
            return new VictorianTable();
        }
    }
}
