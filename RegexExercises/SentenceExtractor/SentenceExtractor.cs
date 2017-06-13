namespace SentenceExtractor
{
    using System;
    using System.Text.RegularExpressions;

    public class SentenceExtractor
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = $@"([a-zA-Z0-9 ]+\b{word}\b\s*.*?[?!.])";
            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0].Value);
            }
        }
    }
}
