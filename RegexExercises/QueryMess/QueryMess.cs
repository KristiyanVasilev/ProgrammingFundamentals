namespace QueryMess
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class QueryMess
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = @"\b[A-Za-z]+=.*[A-Za-z0-9]+\b";
            var regex = new Regex(pattern);            
            var pair = new Dictionary<string, List<string>>();     

            while (input != "END")
            {    
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    var series = match.ToString().Split('&');
                    foreach (var item in series)
                    {
                        var removeJunk = Regex.Replace(item, @"((%20|\+)+)", " ");
                        var splittedMatch = removeJunk.ToString().Split('=');                        
                        var key = splittedMatch[0].Trim();
                        var value = splittedMatch[1].Trim();
                        
                        if (!pair.ContainsKey(key))
                        {
                            pair[key] = new List<string>();
                        }
                        pair[key].Add(value);
                    }
                }                                   
                foreach (var kvp in pair)
                {
                    var printKey = kvp.Key;
                    var printValues = kvp.Value;
                    Console.Write(printKey + "=[{0}]", string.Join(", ", printValues));
                }
                pair.Clear();
                Console.WriteLine();
                input = Console.ReadLine();
            }
        }
    }
}
