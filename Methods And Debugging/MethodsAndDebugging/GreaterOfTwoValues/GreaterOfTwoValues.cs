using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main(string[] args)
        {
            string inputType = Console.ReadLine();
            switch (inputType)
            {
                case "int":
                    int num1 = int.Parse(Console.ReadLine());
                    int num2 = int.Parse(Console.ReadLine());
                    int intResult = GetMax(num1, num2);
                    Console.WriteLine(intResult);
                    break;

                case "char":
                    char char1 = char.Parse(Console.ReadLine());
                    char char2 = char.Parse(Console.ReadLine());
                    char charResult = GetMax(char1, char2);
                    Console.WriteLine(charResult);
                    break;

                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string stringResult = GetMax(firstString, secondString);
                    Console.WriteLine(stringResult);
                    break;
            }
        }
        public static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
        public static char GetMax(char firstChar, char secondChar)
        {
            if (firstChar >= secondChar)
            {
                return firstChar;
            }
            else
            {
                return secondChar;
            }
        }
        public static string GetMax(string firstString, string secondString)
        {
            if (firstString.CompareTo(secondString) >= 0)
            {
                return firstString;
            }
            else
            {
                return secondString;
            }
        }
    }
}
