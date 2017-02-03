namespace PairsByDifference
{
    using System;
    using System.Linq;
    class PairsByDifference
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int s = 0; s < nums.Length; s++)
                {
                    if (nums[i] - nums[s] == difference)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);


        }
    }
}
