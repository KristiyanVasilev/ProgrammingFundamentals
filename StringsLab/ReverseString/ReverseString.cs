namespace ReverseString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine().ToList();
            input.Reverse();
            Console.WriteLine(string.Join("", input));
        }
    }
}
