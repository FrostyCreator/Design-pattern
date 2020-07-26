using Abstract_Factory.FurnitureFactory;
using System;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client(new ModernFurnitureFactiry());
            client1.BuySetFurniture();

            Client client2 = new Client(new VictorianFurnitureFactiry());
            client2.BuySetFurniture();
        }
    }
}
