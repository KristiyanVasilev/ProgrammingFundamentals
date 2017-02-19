namespace ExtractEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var pattern = @"[a-z]+(\.|_|-|\w)*@\w*(\.|_|-)?\w*\.?\w+\.\w+";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }          
        }
    }
}
