public interface Imediator
{
    void AddUser(IUser user);
    void BroadcastMsg(string message, IUser sender);
}