namespace MagicExchagableWorlds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;   

    public class MainClass
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var firstString = input[0];
            var secondString = input[1];
            var map = new Dictionary<char, char>();
            var lenght = Math.Min(firstString.Length, secondString.Length);
            for (int i = 0; i < lenght; i++)
            {
                var currentFirst = firstString[i];
                var currentSecond = secondString[i];
                if (!map.ContainsKey(currentFirst))
                {
                    if (map.ContainsValue(currentSecond))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                    map.Add(currentFirst, currentSecond);
                }
                else
                {
                    if (map[currentFirst] != currentSecond)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            if (firstString.Length == secondString.Length)
            {
                Console.WriteLine("true");
                return;
            }
            var substring = string.Empty;

            if (firstString.Length > secondString.Length)
            {
                substring = firstString.Substring(lenght);
            }
            else
            {
                substring = secondString.Substring(lenght);
            }
            var isContained = true;
            foreach (var letter in substring)
            {
                if (!map.Keys.Contains(letter) && !map.Values.Contains(letter))
                {
                    isContained = false;
                    break;
                }
            }
            if (!isContained)
            {
                Console.WriteLine("false");
                return;
            }
            Console.WriteLine("true");
        }
    }
}
