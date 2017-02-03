using System;
using System.Collections.Generic;

namespace PrintGivenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            var primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primesInRange));

        }
        public static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();
            for (int currentNum = startNum; currentNum <= endNum; currentNum++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;
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
