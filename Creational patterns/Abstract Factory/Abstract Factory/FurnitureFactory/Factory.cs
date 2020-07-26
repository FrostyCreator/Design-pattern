using Abstract_Factory.Products.Chairs;
using Abstract_Factory.Products.Tables;

namespace Abstract_Factory.FurnitureFactory
{
    public abstract class Factory
    {
        public abstract Chair CreateChair();
        public abstract Table CreateTable();
    }
}
