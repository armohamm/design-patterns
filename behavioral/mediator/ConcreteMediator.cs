using System.Collections.Generic;

using System;

public class ConcreteMediator : Imediator
{
    List<IUser> users = new List<IUser>();
    public void AddUser(IUser user)
    {
        users.Add(user);
    }

    public void BroadcastMsg(string message, IUser sender)
    {
        Console.WriteLine(string.Format("{0} sent: {1}", sender, message));
    }
}