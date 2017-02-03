using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMetod
{
    class MaxMetod
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int maxNum = GetMax(firstNum, secondNum, thirdNum);
            Console.WriteLine(maxNum);
        }
        public static int GetMax(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum > secondNum && firstNum > thirdNum)
            {
                return firstNum;
            }
            else if (secondNum > firstNum && secondNum > thirdNum)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
        }
    }
}
