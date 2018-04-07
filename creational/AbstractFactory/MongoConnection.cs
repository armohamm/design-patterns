using AbstractFactory;
using System;

public class MongoConnection : DbConnection
{
    public override void Open()
    {
        Console.WriteLine("Opening MongoDB Connection...");
    }
}