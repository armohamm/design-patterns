using AbstractFactory;
using System;

public class MongoCommand : DbCommand
{
    public override void Execute()
    {
        Console.WriteLine("Exectuing MongoDB Command...");
    }
}