namespace BombNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class BombNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var bombAndRange = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bomb = bombAndRange[0];
            int range = bombAndRange[1];
            int sum = 0;
            var survivourNums = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                var currentNumber = numbers[i];
                if (currentNumber == bomb)
                {
                    for (int s = 0; s < range - i; s++)
                    {

                    }
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
