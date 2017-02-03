namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacentEqualNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var numbers = new List<int>();

            var previous = input[0];
            for (int i = 1; i < input.Count; i++)
            {
                var currentNumber = input[i];
                if (previous == currentNumber)
                {
                    input.RemoveAll(x => x == currentNumber);
                    input.Insert(i, currentNumber + previous);
                    previous = i - 1;
                    
                }

            }
            Console.WriteLine(string.Join(" ", input));

        }
    }
}
