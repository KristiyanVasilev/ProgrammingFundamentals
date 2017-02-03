using System;
using System.Collections.Generic;
using System.Linq;


namespace OddOccurrences
{
    public class OddOccurrences
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToLower().Split(' ').ToList();
            var numOfWords = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!numOfWords.ContainsKey(word))
                {
                    numOfWords[word] = 0;
                }
                numOfWords[word]++;
            }

            var result = new List<string>();

            foreach (var word in numOfWords)
            {
                if (word.Value % 2 != 0)
                {
                    result.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
