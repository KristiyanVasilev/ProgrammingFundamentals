using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriplesOfLetters
{
    class TriplesOfLetters
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());        
            for (int i = 0; i <= n-1; i++)
            {
                for (int s = 0; s <= n-1; s++)
                {
                    for (int j = 0; j <= n-1; j++)
                    {
                        char letter1 = (char)('a' + i);
                        char letter2 = (char)('a' + s);
                        char letter3 = (char)('a' + j);
                        Console.WriteLine("{0}{1}{2}", letter1, letter2,letter3);
                    }
                }
            }
        }
    }
}
