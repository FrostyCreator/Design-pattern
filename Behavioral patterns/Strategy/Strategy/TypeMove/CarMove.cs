using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class CarMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Передвигаюсь на автомобиле");
        }
    }
}
