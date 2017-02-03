using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int digit = 0;
            bool isSpecial = false;

            for (int num = 1; num <= input; num++)
            {
                digit = num;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                }
                isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{digit} -> {isSpecial}");
                sum = 0;
                num = digit;
            }

        }
    }
}
