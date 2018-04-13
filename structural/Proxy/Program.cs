using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            TcpListener listener = new TcpListener(ip, 9999);

            while(true){
                listener.Start();
                Console.WriteLine("Waiting...");
                Socket s = listener.AcceptSocket();

                byte[] b = new byte[100];

                int count = s.Receive(b);

                string input = string.Empty;

                for(int i =0; i < count; i++){
                    input += Convert.ToChar(b[i]);
                }

                IActualPrices prices = new ActualPrices();
                string returnValue = string.Empty;

                switch(input){
                    case "Gold":
                    returnValue = prices.GoldPrice();
                    break;
                    case "Silver":
                    returnValue = prices.SilverPrice();
                    break;
                    case "Dollar":
                    returnValue = prices.DollarToReal();
                    break;
                    default:
                    break;
                }

                ASCIIEncoding asen = new ASCIIEncoding();
                s.Send(asen.GetBytes(returnValue));

                s.Close();
                listener.Stop();
                Console.WriteLine("Response Sent...");
            }
        }
    }
}
