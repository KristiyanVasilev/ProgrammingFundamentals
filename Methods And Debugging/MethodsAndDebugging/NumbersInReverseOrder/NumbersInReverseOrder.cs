using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersInReverseOrder
{
    class NumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            var result = ReverseNums(numbers);            
            Console.WriteLine(result);
        }
        public static string ReverseNums(string input)
        {
           string result = new string(input.ToCharArray().Reverse().ToArray());
            return result;
        }
        
    }
}
