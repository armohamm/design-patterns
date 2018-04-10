using System;

public class WebService : IBridgeComponents {
    public void Send(string messageType){
        Console.WriteLine("Sending " + messageType + " using Webservice.");
    }
}