using System;

namespace AbstractFactory
{
    public class SQLFactory : DBFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SQLConnection();
        }
        public override DbCommand CreateCommand()
        {
            return new SQLCommand();
        }

    }
}
