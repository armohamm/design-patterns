using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            SendData data = new SendEmail();

            data.components = new WebService();
            data.Send();

            data.components = new ThirdPartyAPI();
            data.Send();

            data = new SendSMS();

            data.components = new WebService();
            data.Send();

            data.components = new ThirdPartyAPI();
            data.Send();
        }
    }
}
