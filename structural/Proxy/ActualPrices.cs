using System;

public class ActualPrices : IActualPrices
{
    public string DollarToReal()
    {
        double value = Convert.ToDouble(new Random().Next(1, 100));
        return Convert.ToString(value * 3.34);
    }

    public string GoldPrice()
    {
        return "100";
    }

    public string SilverPrice()
    {
        return "45";
    }
}