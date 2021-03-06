﻿using System;
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
            int num = int.Parse(Console.ReadLine());
            var result = CalculateFactorial(num);
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
    }
}
