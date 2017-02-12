namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class WordCount
    {
        public static void Main()
        {
            var words = File.ReadAllText("words.txt").ToLower().Split().ToList();
            var inputFile = "text.txt";
            var textByWords = File.ReadAllText(inputFile).ToLower().Split(new[] { ',', '.', '!', '?', ' ', '\r', '\n', '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var wordsCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCount[word] = 0;
            }
            for (int i = 0; i < textByWords.Count; i++)
            {
                for (int s = 0; s < words.Count; s++)
                {
                    var currentWord = textByWords[i];
                    var otherWord = words[s];

                    if (currentWord == otherWord)
                    {
                        wordsCount[otherWord]++;
                    }
                }
            }
            var result = wordsCount.OrderByDescending(kvp => kvp.Value).Select(kvp => $"{kvp.Key} - {kvp.Value}").ToList();
            File.WriteAllLines("output.txt", result);         
        }
    }
}
