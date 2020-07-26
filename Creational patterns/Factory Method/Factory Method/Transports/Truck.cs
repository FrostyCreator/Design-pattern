using System;

namespace Factory_Method.Transports
{
    public class Truck : Transport
    {
        public override void Deliver()
        {
            Console.WriteLine("Доставка на грузовике");
        }
    }
}