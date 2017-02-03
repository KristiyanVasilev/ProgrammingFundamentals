using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main(string[] args)
        {
            long input = Math.Abs(long.Parse(Console.ReadLine()));
            string convertedInput = input.ToString();
            var result = DigitName(convertedInput,input);
            Console.WriteLine(result);
        }
        public static string DigitName(string name, long num)
        {
            long lastDigit = num % 10;
            switch (lastDigit)
            {
                case 1:
                    name = "one";
                break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
                case 0:
                    name = "zero";
                    break;
            }
            return name;
        }
    }
}
