namespace SalesReport
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SalesReport
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());
            var sales = new List<Sale>();
            for (int i = 0; i < input; i++)
            {
                var currentSaleParts = Console.ReadLine().Split();
                var currentSale = new Sale
                {
                    Town = currentSaleParts[0],
                    Product = currentSaleParts[1],
                    Price = double.Parse(currentSaleParts[2]),
                    Qunatity = double.Parse(currentSaleParts[3])
                };

                sales.Add(currentSale);
            }

            var result = new SortedDictionary<string, double>();
            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }
                     result[sale.Town] += sale.Price * sale.Qunatity;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }    
}
