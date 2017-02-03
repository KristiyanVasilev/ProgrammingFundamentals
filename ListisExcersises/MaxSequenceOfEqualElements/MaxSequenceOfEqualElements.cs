namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class MaxSequenceOfEqualElements
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 1;
            int MaxCount = 1;
            int number = 0;
            var seqNums = new List<int>();

            if (input.Count > 0)
            {
                var previous = input[0];
                for (int i = 1; i < input.Count; i++)
                {
                    var currentNumber = input[i];
                    if (currentNumber == previous)
                    {
                        count++;
                        if (count > MaxCount)
                        {
                            MaxCount = count;
                            number = currentNumber;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                    previous = currentNumber;
                }
                if (number != 0)
                {
                    for (int i = 0; i < MaxCount; i++)
                    {
                        seqNums.Add(number);
                    }
                    Console.WriteLine(string.Join(" ", seqNums));
                }
                else
                {
                    Console.WriteLine(input[0]);
                }                
            }
        }
    }
}
