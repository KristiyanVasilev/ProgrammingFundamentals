using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double price = double.Parse(Console.ReadLine());
            double div = Proc(lastPrice, price);
            bool isSignificantDifference = IsDifferent(div, threshold);
            string message = Get(price, lastPrice, div, isSignificantDifference);
            lastPrice = price;
            Console.WriteLine(message);
        }
    }

    private static string Get(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
    {
        string result = "";
        if (difference == 0)
        {
            result = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!etherTrueOrFalse)
        {
            result = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            result = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        else if (etherTrueOrFalse && (difference < 0))
        {
            result = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
        }
        return result;
    }
    private static bool IsDifferent(double limit, double isDiff)
    {
        if (Math.Abs(limit) >= isDiff)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double Proc(double previousPrice, double currentPrice)
    {
        double r = (currentPrice - previousPrice) / previousPrice;
        return r * 100;
    }
}
