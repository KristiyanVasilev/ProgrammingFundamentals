namespace UseYourChainsBuddy
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class UseYourChainsBuddy
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"<p>.+?<\/p>";
            var regex = new Regex(pattern);
            var text = string.Empty;
            var matches = regex.Matches(input);
            foreach (Match item in matches)
            {
                var clearedItem = Regex.Replace(item.ToString(), "<p>", string.Empty);
                clearedItem = Regex.Replace(clearedItem, "</p>", string.Empty);
                clearedItem = Regex.Replace(clearedItem, @"[^a-z\d]", " ");
                clearedItem = Regex.Replace(clearedItem, @"\s+", " ");
                var decripted = DecriptItem(clearedItem);
                text += decripted;
            }
            Console.WriteLine(text);
        }

        public static string DecriptItem(string clearedItem)
        {
            var sb = new StringBuilder();
            foreach (var letter in clearedItem)
            {
                if (letter >= 'a' && letter <= 'm')
                {
                    sb.Append((char)(letter + 13));
                }
                else if (letter >= 'n' && letter <= 'z')
                {
                    sb.Append((char)(letter - 13));
                }
                else
                {
                    sb.Append(letter);
                }
            }
            return sb.ToString();
        }
    }
}
