﻿namespace BombNumbers
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
                    int left = Math.Max(i - power, 0);

                    int right = Math.Min(i + power, numbers.Count - 1);

                    int lenght = right - left + 1;
                    numbers.RemoveRange(left, lenght);
                    i = 0;
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
