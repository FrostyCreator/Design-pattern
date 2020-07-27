using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Travel park = new Travel(new BusMove());
            park.Move();

            Travel village = new Travel(new CarMove());
            village.Move();
        }
    }
}
