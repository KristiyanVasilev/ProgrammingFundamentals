using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintASCII
{
    class PrintASCII
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

            char startNum = Convert.ToChar(num1);
            char endNum = Convert.ToChar(num2);

            for (char i = startNum; i <= endNum; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
