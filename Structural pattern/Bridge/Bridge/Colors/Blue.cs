
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Blue : IColor
    {
        public void GetColor()
        {
            Console.WriteLine("Цвет фигуры - синий");
        }

        public void SetColot()
        {
            Console.WriteLine("Фигура покрашена в синий цвет");
        }
    }
}
