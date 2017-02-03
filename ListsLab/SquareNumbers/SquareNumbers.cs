namespace SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SquareNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().
                Split(' ').
                Select(double.Parse).
                ToList();
            var resultList = new List<double>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                var square = Math.Sqrt(currentNumber);
                if (square == (int)square)
                {
                    resultList.Add(currentNumber);
                }
            }
            resultList.Sort((a,b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ", resultList));

        }
    }
}
