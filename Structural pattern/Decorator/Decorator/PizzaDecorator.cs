using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    abstract class PizzaDecorator : Pizza
    {
        protected Pizza pizza;
        public PizzaDecorator(string n, Pizza pizza) : base(n)
        {
            this.pizza = pizza;
        }
    }
}
