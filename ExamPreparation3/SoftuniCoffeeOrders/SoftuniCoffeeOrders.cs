namespace SoftuniCoffeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class MainClass
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var totalPirce = 0m;
            for (int i = 0; i < n; i++)
            {
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var dateFormat = "d/M/yyyy";
                var date = DateTime.ParseExact(Console.ReadLine(), dateFormat, CultureInfo.InvariantCulture);
                var capsulsCount = long.Parse(Console.ReadLine());
                var days = DateTime.DaysInMonth(date.Year, date.Month);
                var price = (capsulsCount * days) * pricePerCapsule;
                totalPirce += price;
                Console.WriteLine("The price for the coffee is: ${0:f2}", price);
            }
            Console.WriteLine("Total: ${0:f2}", totalPirce);
        }
    }
}
