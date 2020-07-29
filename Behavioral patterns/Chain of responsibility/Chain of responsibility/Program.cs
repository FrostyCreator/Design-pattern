using Chain_of_responsibility.Handlers;
using System;

namespace Chain_of_responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler guestHandler = new GuestHandler(null);
            Handler userHandler = new UserHandler(guestHandler);
            Handler handler = new AdminHandler(userHandler);

            User admin = new User() { Position = "Admin" };
            User user = new User() { Position = "User" };
            User guest = new User() { Position = "Guest" };

            handler.Handle(admin);
            handler.Handle(user);
            handler.Handle(guest);
        }
    }
}
