namespace SoftuniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SoftuniKaraoke
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            var awardsBook = new Dictionary<string, HashSet<string>>();

            while (input != "dawn")
            {
                var line = input.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                var participant = line[0].Trim();
                var song = line[1].Trim();
                var award = line[2];

                if (songs.Contains(song) && participants.Contains(participant))
                {
                    if (!awardsBook.ContainsKey(participant))
                    {
                        awardsBook[participant] = new HashSet<string>();
                    }
                    awardsBook[participant].Add(award);
                }

                input = Console.ReadLine();
            }

            if (awardsBook.Count == 0)
            {
                Console.WriteLine("No awards");

            }
            else
            {
                foreach (var participant in awardsBook.OrderByDescending(p => p.Value.Count).ThenBy(p => p.Key))
                {
                    Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
                    foreach (var award in participant.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }            
        }
    }
}
