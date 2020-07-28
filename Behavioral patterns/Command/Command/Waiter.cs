using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    //  официант — командa
    class Waiter : ICommand
    {
        Chef chef;

        public Waiter(Chef chef)
        {
            this.chef = chef;
        }

        public void Execute(string dish)
        {
            this.chef.Cook(dish);
        }

        public void Undo()
        {
            this.chef.AbortCooking();
        }
    }
}
