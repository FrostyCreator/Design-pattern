using System;
using System.Collections.Generic;
using System.Text;

namespace Mediator
{
    abstract class Colleague
    {
        protected Mediator mediator;
        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }

        public virtual void Send(string msg)
        {
            mediator.Send(msg, this);
        }
        public abstract void Notify(string message);
    }
}
