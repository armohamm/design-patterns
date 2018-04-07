using System;
using System.Data.Common;

namespace AbstractFactory
{
    public class SQLConnection : DbConnection
    {
        public override void Open()
        {
            Console.WriteLine("Calling SQL Connection...");
        }
    }
}
