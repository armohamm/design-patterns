using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DBFactory db = new SQLFactory();
            var con = db.CreateConnection();
            con.Open();

            var cmd = db.CreateCommand();
            cmd.Execute();

            db = new MongoFactory();
            con = db.CreateConnection();
            con.Open();

            cmd = db.CreateCommand();
            cmd.Execute();

        }
    }
}
