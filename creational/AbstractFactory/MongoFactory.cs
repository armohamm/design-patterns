using AbstractFactory;

public class MongoFactory : DBFactory
{
    public override DbCommand CreateCommand()
    {
        return new MongoCommand();
    }

    public override DbConnection CreateConnection()
    {
        return new MongoConnection();
    }
}