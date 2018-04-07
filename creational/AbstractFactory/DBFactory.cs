using System;

namespace AbstractFactory
{
    public abstract class DBFactory 
    {
        public abstract DbConnection CreateConnection(); 

        public abstract DbCommand CreateCommand();
    }
}
