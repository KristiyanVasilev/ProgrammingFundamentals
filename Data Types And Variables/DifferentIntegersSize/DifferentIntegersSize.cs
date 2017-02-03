using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            try
            {
                long inputNum = Convert.ToInt64(input);
                Console.WriteLine("{0} can fit in:", inputNum);

                if (inputNum >= sbyte.MinValue && inputNum <= sbyte.MaxValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (inputNum >= byte.MinValue && inputNum <= byte.MaxValue)
                {
                    Console.WriteLine("* byte");
                }
                if (inputNum >= short.MinValue && inputNum <= short.MaxValue)
                {
                    Console.WriteLine("* short");
                }
                if (inputNum >= ushort.MinValue && inputNum <= ushort.MaxValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (inputNum >= int.MinValue && inputNum <= int.MaxValue)
                {
                    Console.WriteLine("* int");
                }
                if (inputNum >= uint.MinValue && inputNum <= uint.MaxValue)
                {
                    Console.WriteLine("* uint");
                }
                if (inputNum >= long.MinValue && inputNum <= long.MaxValue)
                {
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("{0} can't fit in any type", input);
            }
        }
    }
}
