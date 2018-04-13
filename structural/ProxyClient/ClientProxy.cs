using System;

public class ClientProxy
{
    static void Main(string[] args)
    {
        IActualPrices proxy = new ActualPricesProxy();

        try
        {
            Console.WriteLine("Gold Price: ");
            Console.WriteLine(proxy.GoldPrice());

            Console.WriteLine("Silver Price: ");
            Console.WriteLine(proxy.SilverPrice());

            Console.WriteLine("Dollar to Real Conversion: ");
            Console.WriteLine(proxy.DollarToReal());
        }
        catch (Exception ex)
        {
            Console.WriteLine("There was an error: {0}", ex.Message);
        }


    }
}