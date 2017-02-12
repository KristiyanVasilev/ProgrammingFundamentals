namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class LineNumbers
    {
        public static void Main()
        {
            var inputFile = "input.txt";
            var text = File.ReadAllLines(inputFile);
            var lineNumbers = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
               File.AppendAllText("output.txt", $"{i + 1}. {text[i]}{Environment.NewLine}");
            }
        }
    }
}
