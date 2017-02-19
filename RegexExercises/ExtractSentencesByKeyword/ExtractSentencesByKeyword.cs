namespace ExtractSentencesByKeyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Text;

    public class ExtractSentencesByKeyword
    {
        public static void Main()
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine().Split(new char[] { '.', '!', '?' });
            var pattern = "\\b" + word +"\\b";
            var regex = new Regex(pattern);            

            foreach (var sentence in text)
            {                
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
