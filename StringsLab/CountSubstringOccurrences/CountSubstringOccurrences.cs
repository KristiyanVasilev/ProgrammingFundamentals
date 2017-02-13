namespace CountSubstringOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var stringToFind = Console.ReadLine().ToLower();
            var count = 0;
            int index = text.IndexOf(stringToFind);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(stringToFind, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
