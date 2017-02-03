using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            bool isSpecial = false;

            for (int i = 1; i <= input; i++)
            {
                int num = i;
                int sum = 0;
                while (num > 0)
                {
                    sum += num % 10;
                    num = num / 10;
                    if (sum == 5 || sum == 7 || sum == 11)
                    {
                        isSpecial = true;
                    }
                    else
                    {
                        isSpecial = false;
                    }
                   
                }
                Console.WriteLine("{0} -> {1}", i, isSpecial);

            }
        }
    }
}
