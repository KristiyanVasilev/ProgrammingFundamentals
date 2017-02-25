namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class Files
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var files = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var line = input.Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                var root = line.First();
                var extensionAndSize = line.Last().Split(';');
                var fileName = extensionAndSize[0];
                var fileSize = long.Parse(extensionAndSize[1]);
                if (!files.ContainsKey(root))
                {
                    files.Add(root, new Dictionary<string, long>());
                }
                if (!files[root].ContainsKey(fileName))
                {
                    files[root].Add(fileName, fileSize);
                }
                else
                {
                    files[root][fileName] = fileSize;
                }

            }
            var query = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var queryExtension = query[0];
            var queryRoot = query[2];           

            if (!files.ContainsKey(queryRoot))
            {
                Console.WriteLine("No");
            }
            else
            {
                var foundFiles = files[queryRoot];
                foreach (var file in foundFiles.OrderByDescending(f => f.Value).ThenBy(f => f.Key))
                {
                    var extension = file.Key.Split('.').Last();
                    if (extension == queryExtension)
                    {
                        Console.WriteLine($"{file.Key} - {file.Value} KB");                        
                    }
                }
            }            
        }
    }
}
