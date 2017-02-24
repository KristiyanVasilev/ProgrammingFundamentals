namespace EnduranceRally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class EnduranceRally
    {
        public static void Main()
        {
            var drivers = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToList();
            var checkpoint = Console.ReadLine().Split().ToList();

            foreach (var driver in drivers)
            {
                var fuel = (double)driver.First();
                for (int i = 0; i < zones.Count; i++)
                {
                    var currentIndex = i.ToString();
                    if (checkpoint.Contains(currentIndex))
                    {
                        fuel += zones[i];
                    }
                    else
                    {
                        fuel -= zones[i];
                    }
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {i}");
                        break;
                    }

                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:F2}");
                }
            }
        }
    }
}
