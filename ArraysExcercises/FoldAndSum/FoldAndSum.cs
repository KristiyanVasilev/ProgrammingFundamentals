namespace FoldAndSum
{
    using System;
    using System.Linq;

    class FoldAndSum
    {
        static void Main()
        {
            int[] inputaAray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = inputaAray.Length / 4;
            int count = k;

            if (inputaAray.Length == 4)
            {
                int[] smallNumbers = new int[2];
                smallNumbers[0] = inputaAray[0] + inputaAray[1];
                smallNumbers[1] = inputaAray[2] + inputaAray[3];
                Console.WriteLine(string.Join(" ", smallNumbers));
                return;
            }

            int[] firstRow = new int[inputaAray.Length / 2];
            int[] secondRow = new int[inputaAray.Length / 2];

            for (int i = 0; i < k; i++)
            {
                firstRow[i] = inputaAray[count - 1];
                count--;
            }

            int temp = (inputaAray.Length) / 4;
            for (int i = inputaAray.Length - 1; i >= inputaAray.Length - k; i--)
            {
                firstRow[temp - 1] = inputaAray[i];
                temp++;
            }

            for (int i = k; i <= inputaAray.Length - k - 1; i++)
            {
                secondRow[i - k] = inputaAray[i];
            }

            int[] sumArray = new int[secondRow.Length];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = firstRow[i] + secondRow[i];
            }
                      
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
