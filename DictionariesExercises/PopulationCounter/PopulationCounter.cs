namespace PopulationCounter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PopulationCounter
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var population = new Dictionary<string, Dictionary<string, long>>();

            while (input != "report")
            {
                var line = input.Split('|').ToList();
                var city = line[0];
                var country = line[1];
                var count = long.Parse(line[2]);

                if (!population.ContainsKey(country))
                {
                    population[country] = new Dictionary<string, long>();
                }
                population[country][city] = count;              
                input = Console.ReadLine();
            }

            foreach (var country in population.OrderByDescending(x => x.Value.Sum(y => y.Value)))
            {
                var nation = country.Key;
                var town = country.Value;
                var sum = town.Values.Sum();
                Console.WriteLine($"{nation} (total population: {sum})");

                foreach (var village in town.OrderByDescending(x => x.Value))
                {
                    var name = village.Key;
                    var citizens = village.Value;
                    Console.WriteLine($"=>{name}: {citizens}");
                }      
            }

        }
    }
}
