namespace CubicsMessages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;
    using System.Text;

    public class CubicsMessages
    {
        public static void Main()
        {
            while (true)
            {
                var line = Console.ReadLine();                
                if (line == "Over!")
                {
                    break;
                }
                var messageLenght = int.Parse(Console.ReadLine());
                var pattern = $@"^(\d+)([A-Za-z]{{{messageLenght}}})([^A-Za-z]*)$";
                var regex = new Regex(pattern);
                var match = regex.Match(line);
                if (match.Success)
                {
                    var left = match.Groups[1].Value;
                    var message = match.Groups[2].Value;
                    var right = match.Groups[3].Value;

                    var indexes = string.Concat(left, right)
                        .Where(char.IsDigit)
                        .Select(s => s - '0');

                    var sb = new StringBuilder();

                    foreach (var index in indexes)
                    {
                        if (index < 0 || index >= message.Length)
                        {
                            sb.Append(' ');
                        }
                        else
                        {
                            sb.Append(message[index]);
                        }
                    }
                    Console.WriteLine($"{message} == {sb}");
                }               
            }
        }
    }
}
