using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility
{
    abstract class Handler
    {
        public Handler Successor { get; set; }
        public abstract void Handle(User user);
        public Handler(Handler succes)
        {
            Successor = succes;
        }
    }
}
