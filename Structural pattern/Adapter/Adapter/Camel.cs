using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}
