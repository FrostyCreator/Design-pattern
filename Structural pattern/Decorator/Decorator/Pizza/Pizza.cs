using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class Pizza
    {
        public Pizza(string n)
        {
            this.Name = n;
        }
        public string Name { get; protected set; }
        public abstract int GetCost();
    }
}
