using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Visitor Ruslan = new Visitor();
            Chef chef = new Chef();
            Ruslan.SetCommand(new Waiter(chef));

            Ruslan.MakeOrder("Salatik");
            Ruslan.MakeOrder("Kompotik");
            Ruslan.MakeOrder("Apple");
            Ruslan.CancelOrder();
        }
    }
}
