namespace SemanticHTML
{
    using System;
    using System.Text.RegularExpressions;

    public class SemanticHTML
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var pattern = @"<(div)([^>]+)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
            while (line != "END")
            {
                Match openingMatch = Regex.Match(line, pattern);

                Match closingMatch = Regex.Match(line, @"<\/div>\s*<!--\s*(.*?)\s*-->");

                if (openingMatch.Success)
                {
                    line = Regex.Replace(line, pattern, @"$3 $2 $4").Trim();
                    line = "<" + Regex.Replace(line, @"\s+", " ") + ">";
                }
                else if (closingMatch.Success)
                {
                    line = "</" + closingMatch.Groups[1] + ">";
                }
                Console.WriteLine(line);
                line = Console.ReadLine();
            }
        }
    }
}
