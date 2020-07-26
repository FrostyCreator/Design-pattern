using System;

namespace Factory_Method.Transports
{
    public class Ship : Transport
    {
        public override void Deliver()
        {
            Console.WriteLine("Доставка на корабле");
        }
    }
}