namespace FootballStandings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class FootballStandings
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            var line = Console.ReadLine();
            var pattern = $@"{key}(.*?){key}.+?{key}(.*?){key}.+?(\d+):(\d+)";
            var regex = new Regex(pattern);
            var scores = new Dictionary<string, long>();
            var goals = new Dictionary<string, long>();

            while (line != "final")
            {
                var match = regex.Match(line);                
                var firstTeam = new string(match.Groups[1].Value.Reverse().ToArray()).ToUpper();
                var secondTeam = new string(match.Groups[2].Value.Reverse().ToArray()).ToUpper();
                var firstGoals = long.Parse(match.Groups[3].Value);
                var secondGoals = long.Parse(match.Groups[4].Value);

                DefineDictionary(scores, firstTeam);
                DefineDictionary(scores, secondTeam);
                DefineDictionary(goals, firstTeam);
                DefineDictionary(goals, secondTeam);
                goals[firstTeam] += firstGoals;
                goals[secondTeam] += secondGoals;

                if (firstGoals > secondGoals)
                {
                    scores[firstTeam] += 3;
                }
                else if (firstGoals < secondGoals)
                {
                    scores[secondTeam] += 3;
                }
                else
                {
                    scores[firstTeam]++;
                    scores[secondTeam]++;
                }
                line = Console.ReadLine();
            }
            var place = 1;
            Console.WriteLine("League standings:");
            foreach (var team in scores.OrderByDescending(t => t.Value).ThenBy(t => t.Key))
            { 
                Console.WriteLine($"{place}. {team.Key} {team.Value}");
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var kvp in goals.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key).Take(3))
            {
                Console.WriteLine($"- {kvp.Key} -> {kvp.Value}");
            }
            
        }

        public static void DefineDictionary(Dictionary<string, long> dict, string team)
        {
            if (!dict.ContainsKey(team))
            {
                dict[team] = 0;
            }
        }
    }
}
