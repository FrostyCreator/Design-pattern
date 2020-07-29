using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility.Handlers
{
    class GuestHandler : Handler
    {
        public GuestHandler(Handler succes) : base(succes) { }

        public override void Handle(User user)
        {
            if (user.Position.ToLower() == "guest")
                Console.WriteLine("GUEST");
            else if (Successor != null)
                Successor.Handle(user);
        }
    }
}
