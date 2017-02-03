namespace SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Sum = {0}",list.Sum());
            Console.WriteLine("Min = {0}", list.Min());
            Console.WriteLine("Max = {0}", list.Max());
            Console.WriteLine("Average = {0}", list.Average());
        }
    }
}
