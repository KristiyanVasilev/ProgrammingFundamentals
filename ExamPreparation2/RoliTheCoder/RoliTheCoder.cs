namespace RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class RoliTheCoder
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var events = new Dictionary<int, Event>();
            var pattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";
            var regex = new Regex(pattern);

            while (line != "Time for Code")
            {
                var eventDetails = Regex.Match(line, pattern);
                if (eventDetails.Success)
                {
                    var ID = int.Parse(eventDetails.Groups["id"].Value);
                    var eventName = eventDetails.Groups["eventName"].Value;
                    var participants = new string[0];
                    var eventHasParticipants = line.Contains("@");
                    if (eventHasParticipants)
                    {
                        participants = line
                            .Substring(line.IndexOf('@'))
                            .Split()
                            .Where(a => a != string.Empty)
                            .ToArray();
                    }
                    if (!events.ContainsKey(ID))
                    {
                        events[ID] = new Event()
                        {
                            Name = eventName,
                            Participants = new List<string>(new string[0])
                        };
                    }
                    if (events[ID].Name == eventName)
                    {
                        events[ID].Participants.AddRange(participants);
                        events[ID].Participants = events[ID].Participants.Distinct().ToList();
                    }
                }
                line = Console.ReadLine();
            }
            var sortedEvents = events.OrderByDescending(a => a.Value.Participants.Count)
                .ThenBy(a => a.Value.Name)
                .ToArray();

            foreach (var @event in sortedEvents)
            {
                var eventName = @event.Value.Name;
                var participantCount = @event.Value.Participants.Count();
                Console.WriteLine($"{eventName} - {participantCount}");

                var sortedParticipant = @event.Value.Participants.OrderBy(a => a);
                foreach (var participant in sortedParticipant)
                {
                    Console.WriteLine(participant);
                }
                
            }
        }
    }
    public class Event
    { 
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }
}




