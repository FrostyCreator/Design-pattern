using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(new Blue());
            Square square = new Square(new Green());

            circle.Paint(new Green());

            Console.WriteLine();

            square.Paint(new Blue());
        }
    }
}
