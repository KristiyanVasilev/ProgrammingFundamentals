namespace ExtractMiddleElements
{
    using System;
    using System.Linq;

    class ExtractMiddleElements
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            if (nums.Length == 1)
            {
                Console.Write("{");
                Console.Write($"{nums[0]}");
                Console.WriteLine("}");
            }
            else if (nums.Length % 2 == 0)
            {
                int[] printNums = new int[2];
                printNums[0] = nums[nums.Length / 2 - 1];
                printNums[1] = nums[nums.Length / 2];
                Console.WriteLine("{" + string.Join(",", printNums) + "}");
            }
            else if (nums.Length % 2 != 0)
            {
                int[] printNums = new int[3];
                printNums[0] = nums[nums.Length / 2 - 1];
                printNums[1] = nums[nums.Length / 2];
                printNums[2] = nums[nums.Length / 2 + 1];
                Console.WriteLine("{" + string.Join(",", printNums) + "}");
            }
        }
    }
}
