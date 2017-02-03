namespace SortNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().
                Split(' ').
                Select(double.Parse).
                ToList();
            numbers.Sort();
            Console.WriteLine(string.Join(" <= ", numbers));
        }
    }
}
