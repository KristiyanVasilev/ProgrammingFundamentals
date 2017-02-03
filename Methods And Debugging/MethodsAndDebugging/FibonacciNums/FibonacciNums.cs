using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNums
{
    class FibonacciNums
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var result = FibbonaciNumbers(input);
            Console.WriteLine(result);
        }
        public static int FibbonaciNumbers(int n)
        {
            int f0 = 1;
            int f1 = 1;
            int fPlus = 0;

            for (int i = 1; i < n; i++)
            {
                if (n < 2)
                {
                    break;
                }
                fPlus = f0 + f1;
                f0 = f1;
                f1 = fPlus;
            }
            return f1;
        }
    }
}
