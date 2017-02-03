using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());
            var result = TrailingZeros(CalculateFactorial(num));
            Console.WriteLine(result);

        }
        public static BigInteger CalculateFactorial(BigInteger number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        public static BigInteger TrailingZeros(BigInteger num)
        {
            //CalculateFactorial(num);
            BigInteger lastDigit = 0;
            BigInteger sum = 0;

            while (num % 10 == 0)
            {
                lastDigit = num % 10;
                if (lastDigit == 0)
                {
                    sum++;
                }
                num /= 10;
            }
            return sum;
        }
    }
}
