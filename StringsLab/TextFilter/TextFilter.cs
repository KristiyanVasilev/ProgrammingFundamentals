namespace TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            var bannWords = Console.ReadLine().Split(new[] { ',', ' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var text = Console.ReadLine();

            foreach (var word in bannWords)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);

        }
    }
}
