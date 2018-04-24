using System;

namespace mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Imediator mediator = new ConcreteMediator();
            IUser user1 = new ConcreteUser(mediator);
            IUser user2 = new ConcreteUser(mediator);
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            user1.SendMessage("This is user number 1!");
            user2.SendMessage("This is user number 2!");
        }
    }
}
