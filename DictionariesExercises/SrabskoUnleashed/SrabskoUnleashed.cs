namespace SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class SrabskoUnleashed
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var pattern = @"([A-Za-z]+\s*[A-Za-z]*\s*[A-Za-z]*)\s+@([A-Za-z]+\s*[A-Za-z]*\s*[A-Za-z]*)\s+(\d+)\s+(\d+)";
            var regex = new Regex(pattern);
            var venueSinger = new Dictionary<string, Dictionary<string, decimal>>();

            while (line != "End")
            {
                var match = regex.Match(line);
                if (match.Success)
                {
                    var singer = match.Groups[1].Value;
                    var venue = match.Groups[2].Value;
                    var ticketPrice = decimal.Parse(match.Groups[3].Value);
                    var ticketCount = decimal.Parse(match.Groups[4].Value);
                    var totalTicketsPrice = ticketPrice * ticketCount;

                    if (!venueSinger.ContainsKey(venue))
                    {
                        venueSinger[venue] = new Dictionary<string, decimal>();
                    }
                        if (!venueSinger[venue].ContainsKey(singer))
                        {
                            venueSinger[venue][singer] = 0m;
                        }
                        venueSinger[venue][singer] += totalTicketsPrice;
                }
                line = Console.ReadLine();
            }

            foreach (var venue in venueSinger)
            {
                var venueName = venue.Key;
                Console.WriteLine(venueName);
                var singers = venue.Value;

                foreach (var singer in singers.OrderByDescending(x => x.Value))
                {
                    var name = singer.Key;
                    var tickets = singer.Value;
                    Console.WriteLine($"#  {name} -> {tickets}");
                }
            }
        }
    }
}
