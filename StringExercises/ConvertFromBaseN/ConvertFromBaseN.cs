namespace ConvertFromBaseN
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Numerics;
   
    class ConvertFromBaseN
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var numbers = input.Split().ToList();
            var baseNum = BigInteger.Parse(numbers[0]);
            var number = BigInteger.Parse(numbers[1]);
            var result = string.Empty;

            if (baseNum >= 2 && baseNum <= 10)
            {
                while (number != 0)
                {
                    var value = number % baseNum;
                    var num = value.ToString();
                    result = result.Insert(0, num);
                    number /= baseNum;
                }
                Console.WriteLine(result);
            }
        }
    }
}
