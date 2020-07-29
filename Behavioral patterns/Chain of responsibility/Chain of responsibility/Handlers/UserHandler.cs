using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility.Handlers
{
    class UserHandler : Handler
    {
        public UserHandler(Handler succes) : base(succes) { }

        public override void Handle(User user)
        {
            if (user.Position.ToLower() == "user")
                Console.WriteLine("USER");
            else if (Successor != null)
                Successor.Handle(user);
        }
    }
}
