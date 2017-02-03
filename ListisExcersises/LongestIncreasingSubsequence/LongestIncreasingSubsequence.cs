namespace LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LongestIncreasingSubsequence
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var subseqList = new List<int>();
            if (numbers.Count > 1)
            {


            }
            else
            {
                Console.WriteLine(numbers[0]);
            }
        }
    }
}
