namespace RandomizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RandomizeWords
    {
        static void Main()
        {
            var words = Console.ReadLine().Split().ToList();
            var random = new Random();           

            for (int i = 0; i < words.Count; i++)
            {
                var currentWord = words[i];
                var randomIndex = random.Next(0, words.Count);
                var temp = words[randomIndex];
                words[i] = temp;
                words[randomIndex] = currentWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
