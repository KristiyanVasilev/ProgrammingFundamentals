namespace MostFrequentNumber
{
    using System;
    using System.Linq;

    class MostFrequentNumber
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //int digit = 0         
            int count = 0;
            int element = 0;
            int maxCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int tempElement = numbers[i];
                int tempCount = 0;
                for (int s = i; s < numbers.Length; s++)
                {
                    if (numbers[s] == tempElement)
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    element = tempElement;
                    count = tempCount;
                }
            }
            Console.WriteLine(element);
        }
    }
}
