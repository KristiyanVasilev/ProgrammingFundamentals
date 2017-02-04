namespace DragonArmy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DragonArmy
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var type = tokens[0];
                var name = tokens[1];

                var damage = tokens[2] != "null" ? decimal.Parse(tokens[2]) : 45;
                var health = tokens[3] != "null" ? decimal.Parse(tokens[3]) : 250;
                var armor = tokens[4] != "null" ? decimal.Parse(tokens[4]) : 10;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }
                dragons[type][name] = new decimal[] { damage, health, armor };
            }

            foreach (var type in dragons)
            {
                var typeName = type.Key;
                var dragonsByType = type.Value;

                var averageDamage = dragonsByType.Values.Average(a => a[0]);
                var averageHealth = dragonsByType.Values.Average(a => a[1]);
                var averageArmor = dragonsByType.Values.Average(a => a[2]);

                Console.WriteLine($"{typeName}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");

                foreach (var dragon in dragonsByType)
                {
                    var name = dragon.Key;
                    var stats = dragon.Value;
                    var damage = stats[0];
                    var health = stats[1];
                    var armor = stats[2];
                    Console.WriteLine($"-{name} -> damage: {damage}, health: {health}, armor: {armor}");
                }
            }
        }
    }
}
