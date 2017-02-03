namespace LargestThreeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestThreeNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList()
                .OrderByDescending(x => x)
                .Take(3);

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
