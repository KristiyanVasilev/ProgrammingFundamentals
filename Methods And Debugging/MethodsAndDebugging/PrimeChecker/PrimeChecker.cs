using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            var input = long.Parse(Console.ReadLine());
            var result = IsPrime(input);
            Console.WriteLine(result);
        }
        public static bool IsPrime(long num)
        {
            bool prime = true;
            bool underTwo = num <= 2;

            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            if (prime && underTwo == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
