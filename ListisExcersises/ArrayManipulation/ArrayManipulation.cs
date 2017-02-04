namespace ArrayManipulation
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ArrayManipulation
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var numbers = input.Split().Select(int.Parse).ToList();
            while (true)
            {
                input = Console.ReadLine();
                if (input == "print")
                {
                    Console.WriteLine("[" + string.Join(", ", numbers) + "]");
                    break;
                }
                var line = input.Split().ToList();
                var word = line[0];
                var nums = new List<int>();
                for (int i = 1; i < line.Count; i++)
                {
                    nums.Add(int.Parse(line[i]));
                }

                switch (word)
                {
                    case "add":
                        numbers.Insert(nums[0], nums[1]);
                        break;
                    case "contains":

                        if (numbers.Contains(nums[0]))
                        {
                            Console.WriteLine(numbers.IndexOf(nums[0]));
                        }
                        else
                        {
                            Console.WriteLine("-1");
                        }
                        break;
                    case "remove":
                        numbers.RemoveAt(nums[0]);
                        break;
                    case "sumPairs":
                        for (int i = 1; i < numbers.Count; i++)
                        {
                            numbers[i - 1] += numbers[i];
                            numbers.Remove(numbers[i]);
                        }
                        break;
                    case "shift":
                        var count = nums[0];
                        for (int i = 0; i < count; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstNum);
                        }
                        break;
                    case "addMany":
                        for (int i = nums.Count - 1; i > 0; i--)
                        {
                            numbers.Insert(nums[0], nums[i]);
                        }
                        break;
                }
            }
        }
    }
}
