namespace CondenseArrayToNumber
{
    using System;
    using System.Linq;

    class CondenseArrayToNumber
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length - 1];

            if (nums.Length == 1)
            {
                Console.WriteLine(nums[0]);
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < condensed.Length - i; j++)
                {
                    condensed[j] = nums[j] + nums[j + 1];
                   // nums[i + 1] = condensed[i];
                }
                nums = condensed;
            }
            Console.WriteLine(condensed[0]);

        }
    }
}
