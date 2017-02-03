namespace CountRealNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountRealNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            var countNumbers = new Dictionary<double, double>();

            foreach (var number in input)
            {
                if (!countNumbers.ContainsKey(number))
                {
                    countNumbers[number] = 0;
                }
                countNumbers[number]++;
            }

            var result = countNumbers
                .OrderBy(x => x.Key)
                .ThenBy(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
