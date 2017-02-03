using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            FirstLine(input);
            MiddleRow(input);
            FirstLine(input);

        }
        public static void FirstLine(int num)
        {
            Console.WriteLine("{0}", new string('-', num * 2));
        }
        public static void MiddleRow(int num)
        {

            for (int i = 1; i < num - 1; i++)
            {
                Console.Write("-");
                for (int s = 0; s < num-1; s++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine("-");
            }
        }
    }
}
