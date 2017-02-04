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
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToList();
            int bomb = tokens[0];
            int power = tokens[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int s = numbers[i]; s > power; s--)
                    {
                        numbers.Remove(numbers[s - 1]);
                    }
                    numbers.Remove(numbers[i]);
                    
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
