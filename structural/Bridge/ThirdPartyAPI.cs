using System;

public class ThirdPartyAPI : IBridgeComponents {
    public void Send(string messageType){
        Console.WriteLine("Sending " + messageType + " using Third party API.");
    }
}