namespace Test
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var numbers = new int[input];
            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
