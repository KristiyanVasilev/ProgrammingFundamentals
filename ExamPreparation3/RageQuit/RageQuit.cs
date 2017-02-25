namespace RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;


    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToUpper();
            var pattern = @"(\D)+[0-9]+";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);
            var sb = new StringBuilder();            

            foreach (Match match in matches)
            {
                var takeDigit = new Regex(@"\d+");
                var matchDigit = takeDigit.Match(match.ToString());
                var count = int.Parse(matchDigit.ToString());
                var message = match.ToString().Replace(matchDigit.ToString(), string.Empty);
                
                for (int i = 0; i < count; i++)
                {
                    sb.Append(message);
                }
            }
            Console.WriteLine($"Unique symbols used: {sb.ToString().Distinct().Count()}");
            Console.WriteLine(sb.ToString());
        }
    }
}
