namespace RotateAndSum
{
    using System;
    using System.Linq;

    class RotateAndSum
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            //var reversedArray = new int[];
            int[] sum = new int[numbers.Length];
            for (int i = 0; i < n; i++)
            {
                int lastNumber = numbers[numbers.Length - 1];
                 
                for (int j = numbers.Length - 1; j > 0; j--)
                {
                    numbers[j] = numbers[j - 1];
                } 

                numbers[0] = lastNumber;
                for (int j = 0; j < numbers.Length; j++)
                {
                    sum[j] += numbers[j];
                }
            }      
            
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
