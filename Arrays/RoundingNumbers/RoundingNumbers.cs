namespace RoundingNumbers
{
    using System;


    class RoundingNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] items = input.Split(' ');
            double[] nums = new double[items.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = double.Parse(items[i]);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"{items[i]} -> {nums[i]}");
            }


        }
    }
}
