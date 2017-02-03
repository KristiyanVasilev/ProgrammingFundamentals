namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AppendLists
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            input.Reverse();
            var result = new List<string>();
            foreach (var numbers in input)
            {
                List<string> nums = numbers.Split(' ').ToList();
                foreach (var num in nums)
                {
                    if (num != "") result.Add(num);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

    }
 }
