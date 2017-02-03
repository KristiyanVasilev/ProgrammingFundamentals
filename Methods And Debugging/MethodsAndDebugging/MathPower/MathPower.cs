using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = MathPow(a, b);
            Console.WriteLine(result);

        }
        public static double MathPow(double num1, double num2)
        {
            return Math.Pow(num1, num2);
            
        }
    }
}
