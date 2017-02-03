using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            Calculations(side, parameter);  
        }
        public static void Calculations(double num, string type)
        {         
            switch (type)
            {
                case "face":
                Console.WriteLine("{0:f2}", Math.Sqrt(2 * Math.Pow(num, 2)));              
                break;
                case "space":
                Console.WriteLine("{0:f2}", Math.Sqrt(3 * Math.Pow(num, 2)));
                break;
                case "volume":
                Console.WriteLine("{0:f2}", Math.Pow(num, 3));
                break;
                case "area":
                Console.WriteLine("{0:f2}", 6 * Math.Pow(num, 2));
                break;
            }
        }

    }
}
