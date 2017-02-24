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
            var input = Console.ReadLine();
            var eventList = new SortedDictionary<string, SortedDictionary<string, HashSet<string>>>();
            var pattern = @"(?<id>\d+)\s+#(?<eventName>[\w\d]+)(\s+(?:@\w+\s*)+)?";
            var regex = new Regex(pattern);

            while (input != "Time for Code")
            {
                if (regex.IsMatch(input))
                {
                    var line = input.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                    var ID = line[0];
                    var eventName = line[1];
                    var participants = new HashSet<string>();
                    for (int i = 2; i < line.Count; i++)
                    {
                        var currentParticipant = line[i];
                        if (currentParticipant.StartsWith("@"))
                        {
                            participants.Add(currentParticipant);
                        }                        
                    }
                    if (!eventList.ContainsKey(ID))
                    {
                        eventList[ID] = new SortedDictionary<string, HashSet<string>>();
                                            }
                    else
                    {
                        if (!eventList[ID].ContainsKey(eventName))
                        {
                            input = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            eventList[ID][eventName] = participants;
                        }
                    }  

                    input = Console.ReadLine();
                }
                else
                {
                    input = Console.ReadLine();
                }
            }

            foreach (var ID in eventList
                     .Values
                     .OrderByDescending(x => x.Values.Sum(y => y.Count)))
            {
                foreach (var eventName in ID)
                {
                    var eventToPrint = eventName.Key.Remove(0, 1);
                    var countToPrint = eventName.Value.Count;
                    Console.WriteLine(eventToPrint + " - " + countToPrint);
                    foreach (var participant in eventName.Value.OrderBy(p => p))
                    {
                        Console.WriteLine(participant);
                    }
                }
            }
        }
    }
}

