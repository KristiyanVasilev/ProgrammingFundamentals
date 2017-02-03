namespace SumArrays
{
    using System;
    using System.Linq;

    class SumArrays
    {
        static void Main()
        {
            string[] firstInput = Console.ReadLine().Split(' ').ToArray();
            string[] secondInput = Console.ReadLine().Split(' ').ToArray();
            var firstNums = new int[firstInput.Length];
            var secondNums = new int[secondInput.Length];
            for (int i = 0; i < firstInput.Length; i++)
            {
                firstNums[i] = int.Parse(firstInput[i]);
            }

            for (int i = 0; i < secondInput.Length; i++)
            {
                secondNums[i] = int.Parse(secondInput[i]);
            }

            int len1 = firstNums.Length;
            int len2 = secondNums.Length;
            var sumArr = new int[Math.Max(len1, len2)];

            for (int i = 0; i <= sumArr.Length - 1; i++)
            {
                sumArr[i] = firstNums[i % len1] + secondNums[i % len2];
            }

            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
