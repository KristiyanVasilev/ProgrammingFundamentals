namespace MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            var input = "";
            var resources = new Dictionary<string, int>();
            while (input != "stop")
            {
                input = Console.ReadLine();
                if (input != "stop")
                {
                    var quantity = int.Parse(Console.ReadLine());
                    if (!resources.ContainsKey(input))
                    {
                        resources[input] = quantity;
                    }
                    else
                    {
                        resources[input] += quantity;
                    }              
                }               
            }
            foreach (var mineral in resources)
            {
                Console.WriteLine($"{mineral.Key} -> {mineral.Value}");
            }
        }
    }
}
