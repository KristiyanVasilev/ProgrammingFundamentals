namespace LettersChangeNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class LettersChangeNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            var sum = 0.0m;
            var firstPattern = @"[A-Za-z]\d+[A-Za-z]";
            var firstRegex = new Regex(firstPattern);

            foreach (var item in input)
            {
                if (firstRegex.IsMatch(item))
                {
                    var firstLetter = item.First();
                    var lastLetter = item.Last();
                    var pattern = @"\d+";
                    var regex = new Regex(pattern);
                    var match = regex.Match(item).ToString();
                    var digits = Convert.ToDecimal(match);
                    var firstIndex = (int)firstLetter % 32;
                    var lastIndex = (int)lastLetter % 32;
                    if (firstLetter.ToString() == firstLetter.ToString().ToUpper())
                    {
                        sum += digits / firstIndex;

                    }
                    else
                    {
                        sum += digits * firstIndex;
                    }
                    if (lastLetter.ToString() == lastLetter.ToString().ToUpper())
                    {
                        sum -= lastIndex;
                    }
                    else
                    {
                        sum += lastIndex;
                    }
                }
                else
                {
                    return;
                }
            }               
            Console.WriteLine("{0:F2}", sum);
        }
    }
}
