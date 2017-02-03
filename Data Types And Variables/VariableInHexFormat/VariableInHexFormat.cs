using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableInHexFormat
{
    class VariableInHexFormat
    {
        static void Main(string[] args)
        {
            string hex = Console.ReadLine();
            int decimalNum = Convert.ToInt32(hex, 16);
            Console.WriteLine(decimalNum);
        }
    }
}
