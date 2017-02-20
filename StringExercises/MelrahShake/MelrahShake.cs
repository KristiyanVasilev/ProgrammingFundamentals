namespace MelrahShake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Text;
    using System.Threading.Tasks;

    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stringToRemove = Console.ReadLine();
            var shakeIt = true;

            while (shakeIt)
            {
                if (input == string.Empty)
                {
                    shakeIt = false;
                    break;
                }
                if (input.Contains(stringToRemove))
                {
                    var firstOccurance = input.IndexOf(stringToRemove);
                    input = input.Remove(firstOccurance, stringToRemove.Length);
                    
                    if (input.Contains(stringToRemove))
                    {
                        var lastOccurane = input.LastIndexOf(stringToRemove);
                        input = input.Remove(lastOccurane, stringToRemove.Length);
                        input = input.Trim();
                        Console.WriteLine("Shaked it.");
                        var len = stringToRemove.Length / 2;
                        stringToRemove = stringToRemove.Remove(len, 1);
                        if (stringToRemove == string.Empty)
                        {
                            Console.WriteLine("No shake.");
                            shakeIt = false;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shaked it.");
                    }
                }
                else
                {
                    Console.WriteLine("No shake.");
                    shakeIt = false;
                    break;
                }
            }
            if (input != string.Empty)
            {
                Console.WriteLine(input.Trim());
            }
        }
    }
}
