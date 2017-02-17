namespace ReplaceTag
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    class ReplaceTag
    {
        static void Main()
        {
            string text = Console.ReadLine();
            while (text != "end")
            {
                string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
                string replace = @"[URL href=$1]$2[/URL]";
                string replaced = Regex.Replace(text, pattern, replace);
                Console.WriteLine(replaced);
                text = Console.ReadLine();
            }
        }
    }
}
