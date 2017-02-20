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
            var pattern = @"\b(?<!\.|\-|_)([a-zA-Z][\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+\b";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                var mail = match.ToString();
                Console.WriteLine(mail);
            }          
        }
    }
}
