using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    interface ICommand
    {
        void Execute(string dish);
        void Undo();
    }
}
