using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            object finalString = firstString + " " + secondString;
            string thirdString = (string)finalString;
            Console.WriteLine(thirdString);
        }
    }
}
