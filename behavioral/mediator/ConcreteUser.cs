public class ConcreteUser : IUser
{
    Imediator mediator;

    public ConcreteUser(Imediator mediator){
        this.mediator = mediator;
    }
    public void SendMessage(string message)
    {
        mediator.BroadcastMsg(message, this);
    }
}