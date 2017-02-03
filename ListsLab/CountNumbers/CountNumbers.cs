namespace CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class CountNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            numbers.Sort();
            var previous = numbers[0];
            int count = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == previous)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine(previous + " -> " + count);
                    count = 1;
                }
                previous = currentNumber;                
            }
            Console.WriteLine(previous + " -> " + count);
        }
    }
}
