using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordsSorted
{
    public class ShortWordsSorted
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var result = text
                .ToLower()
                .Split(new char[] {'.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' })
                .Distinct() //remove duplicate words
                .Where(x => x.Length < 5 && x != "")
                .OrderBy(x => x);

            Console.WriteLine(string.Join(", ", result));
        }
    }
}
