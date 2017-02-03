namespace LargestCommonEnd
{
    using System;
    using System.Linq;
    class LargestCommonEnd
    {
        static void Main()
        {
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();
            int len1 = firstInput.Length;
            int len2 = secondInput.Length;
            int sumLeft = 0;
            int sumRight = 0;

            for (int i = 0; i < Math.Min(len1, len2); i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    sumLeft++;
                }
                if (firstInput[len1 - 1 - i] == secondInput[len2 - 1 - i])
                {
                    sumRight++;
                }
            }

            if (sumLeft >= sumRight)
            {
                Console.WriteLine(sumLeft);
            }
            else
            {
                Console.WriteLine(sumRight);
            }  
        }
    }
}
