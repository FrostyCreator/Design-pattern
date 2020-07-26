using Abstract_Factory.FurnitureFactory;
using Abstract_Factory.Products.Chairs;
using Abstract_Factory.Products.Tables;

namespace Abstract_Factory
{
    class Client
    {
        private Chair chair;
        private Table table;

        public Client(Factory factory)
        {
            chair = factory.CreateChair();
            table = factory.CreateTable();
        }
        public void BuySetFurniture()
        {
            chair.BuyChair();
            table.BuyTable();
        }
    }
}
