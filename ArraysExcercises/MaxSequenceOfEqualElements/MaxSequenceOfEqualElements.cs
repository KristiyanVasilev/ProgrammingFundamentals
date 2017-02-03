namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int pos = 0;
            int count = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        pos = i - count;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = pos + 1; i <= pos + maxCount + 1; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
