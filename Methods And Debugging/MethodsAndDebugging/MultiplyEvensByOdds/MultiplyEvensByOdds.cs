using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class MultiplyEvensByOdds
    {
        static void Main(string[] args)
        {
            int input = Math.Abs(int.Parse(Console.ReadLine()));
            var result = MultiplyDigits(input);
            Console.WriteLine(result);
        }
        public static int GetOdds(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
        public static int GetEvens(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }
                num /= 10;
            }
            return sum;
        }
        public static int MultiplyDigits(int n)
        {
            int odds = GetOdds(n);
            int evens = GetEvens(n);
            return odds * evens;

        }
    }
}
