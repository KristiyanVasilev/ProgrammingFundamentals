namespace NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .OrderBy(d => d);            
            var pattern = @"(-*\+*\d+\.*\d*)";
            var digitsInName = new Regex(pattern);
            var starsOrDashes = new Regex(@"(\*|\/)");
            var letters = new Regex(@"[^0-9-+*\.\/]");

            foreach (var demon in demons)
            {
                long health = 0;
                var damage = 0.0m;
                var digits = digitsInName.Matches(demon);

                foreach (Match match in digits)
                {
                    var num = decimal.Parse(match.Value);
                    damage += num;
                }

                var matchStarsOrDashes = starsOrDashes.Matches(demon);
                foreach (Match match in matchStarsOrDashes)
                {
                    if (match.Value == "*")
                    {
                        damage *= 2;
                    }
                    else if (match.Value == "/")
                    {
                        damage /= 2;
                    }
                }
                var matchLetters = letters.Matches(demon);
                foreach (Match match in matchLetters)
                {
                    var letter = Convert.ToChar(match.Value);
                    health += (long)letter;
                }                
                Console.WriteLine($"{demon} - {health} health, {damage:f2} damage");
            }
        }
    }
}
