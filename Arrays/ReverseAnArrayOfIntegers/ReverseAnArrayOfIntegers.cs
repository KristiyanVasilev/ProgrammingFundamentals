namespace ReverseAnArrayOfIntegers
{
    using System;

    class ReverseAnArrayOfIntegers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                int currentNum = num;
                numbers[i] = currentNum;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
