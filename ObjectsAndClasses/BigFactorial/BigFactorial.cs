namespace BigFactorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    class BigFactorial
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger bigNumber = 1;

            for (int i = 2; i <= number; i++)
            {
                bigNumber *= i;
            }
            Console.WriteLine(bigNumber);
        }
    }
}
