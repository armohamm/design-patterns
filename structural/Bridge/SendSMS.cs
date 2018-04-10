public class SendSMS : SendData{
    public override void Send(){
        components.Send("SMS");
    }
}