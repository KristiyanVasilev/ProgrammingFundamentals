namespace ConvertToBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;

    class ConvertToBaseN
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var numbers = input.Split().ToList();
            var baseNum = int.Parse(numbers[0]);
            var number = BigInteger.Parse(numbers[1]);
            BigInteger result = 0;
            var count = 0;
            BigInteger sum = 0;

            if (baseNum >= 2 && baseNum <= 10)
            {
                while (number != 0)
                {
                    result = ((number % 10l) * BigInteger.Pow(baseNum, count));
                    sum += result;
                    count++;
                    number /= 10;                    
                }
                Console.WriteLine(sum);
            }
        }
    }
}
