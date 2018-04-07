using System;

namespace AbstractFactory
{
    public class SQLCommand : DbCommand 
    {
        public override void Execute(){
            Console.WriteLine("Executing SQL Command...");
        }
    }
}
