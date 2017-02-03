using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class FastPrimeChecker
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int firstNum = 2; firstNum <= input; firstNum++)
            {
                bool isPrime = true;
                for (int s = 2; s <= Math.Sqrt(firstNum); s++)
                {
                    if (firstNum % s == 0)
                    {
                        isPrime = false;
                        break;                       
                    }
                }
                Console.WriteLine($"{firstNum} -> {isPrime}");
            }
        }
    }
}
