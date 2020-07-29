using System;
using System.Collections.Generic;
using System.Text;

namespace Chain_of_responsibility.Handlers
{
    class AdminHandler : Handler
    {
        public AdminHandler(Handler succes) : base(succes) { }

        public override void Handle(User user)
        {
            if (user.Position.ToLower() == "admin")
                Console.WriteLine("ADMIN");
            else if(Successor != null)
                Successor.Handle(user);
        }
    }
}
