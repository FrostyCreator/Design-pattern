using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Green : IColor
    {
        public void GetColor()
        {
            Console.WriteLine("Цвет фигуры - зелёный");
        }

        public void SetColot()
        {
            Console.WriteLine("Фигура покрашена в зелёный");
        }
    }
}
