namespace MergeFiles
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;

    public class MergeFiles
    {
        public static void Main()
        {
            var firstFile = "FileOne.txt";
            var secondFile = "FileTwo.txt";
            var first = File.ReadAllLines(firstFile);
            var second = File.ReadAllLines(secondFile);
            var result = "";
            for (int i = 0; i < Math.Max(first.Length, second.Length); i++)
            {
                result += first[i] + Environment.NewLine + second[i] + Environment.NewLine; 
            }
            File.WriteAllText("output.txt", result);
        }
    }
}
