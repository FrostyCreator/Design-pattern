using System;
using System.Collections.Generic;
using System.Text;

namespace Command
{
    // Invoker - инициатор
    class Visitor
    {
        ICommand command;
        public void SetCommand(ICommand com)
        {
            command = com;
        }
        public void MakeOrder(string order)
        {
            command.Execute(order);
        }
        public void CancelOrder() 
        { 
            command.Undo(); 
        }
    }
}
