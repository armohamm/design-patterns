using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

public class ActualPricesProxy : IActualPrices
{
    public string DollarToReal()
    {
        return GetResponseFromServer("Dollar");
    }

    public string GoldPrice()
    {
        return GetResponseFromServer("Gold");
    }

    public string SilverPrice()
    {
        return GetResponseFromServer("Price");
    }

    private string GetResponseFromServer(string input)
    {
        string result = string.Empty;
        using (TcpClient client = new TcpClient())
        {
            client.Connect("127.0.0.1", 9999);
 
            Stream stream = client.GetStream();
 
            ASCIIEncoding asen = new ASCIIEncoding();
            byte[] ba = asen.GetBytes(input.ToCharArray());
 
            stream.Write(ba, 0, ba.Length);
 
            byte[] br = new byte[100];
            int k = stream.Read(br, 0, 100);
 
            
 
            for (int i = 0; i < k; i++)
            {
                result += Convert.ToChar(br[i]);
            }
 
            client.Close();
        }
        return result;
    }
}