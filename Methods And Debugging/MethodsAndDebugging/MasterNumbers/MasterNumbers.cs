using System;

namespace MasterNumbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 161; i < input; i++)
            {
                if (ContainsEvenDigit(i) && DivisibleBySeven(i) && IssSymmetric(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IssSymmetric(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != sNum[sNum.Length - 1 - i])
                {
                    return false;
                } 
            return true;
        }

        public static bool DivisibleBySeven(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;                 
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool ContainsEvenDigit(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                int number = num % 10;
                if (number % 2 == 0)
                {
                    return true;
                }
                //sum += number;                
                num /= 10;
            }
            return false;
        }
    }
}
