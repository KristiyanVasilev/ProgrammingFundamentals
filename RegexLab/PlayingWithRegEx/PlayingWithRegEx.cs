namespace PlayingWithRegEx
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.IO;

    class PlayingWithRegEx
    {
        static void Main()
        {
            var text = File.ReadAllText("names.txt").ToString();
            var regex = new Regex(@"[A-Z][a-z]+\s[A-Z][a-z]+");
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
