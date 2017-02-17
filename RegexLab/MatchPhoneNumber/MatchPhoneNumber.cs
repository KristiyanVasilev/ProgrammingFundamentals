namespace MatchPhoneNumber
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.IO;

    class MatchPhoneNumber
    {
        static void Main()
        {
            var text = File.ReadAllText("phones.txt");
            var regex = new Regex(@"\+\d{3}(\s|\-)\d{1}\1\d{3}\1\d{4}");
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }            
        }
    }
}
