namespace LogsAggregator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class LogsAggregator
    {
        static void Main()
        {
            var entryNumber = int.Parse(Console.ReadLine());
            var logs = new SortedDictionary<string, SortedDictionary<string, int>>();
            for (int i = 0; i < entryNumber; i++)
            {
                var line = Console.ReadLine().Split().ToList();
                var username = line[1];
                var ip = line[0];
                var count = int.Parse(line[2]);
                AddUsername(logs, username);
                AddUsernameIP(logs, username, ip, count);
            }

            PrintLogs(logs);            
        }

        public static void PrintLogs(SortedDictionary<string, SortedDictionary<string, int>> logs)
        {
            foreach (var user in logs)
            {
                var username = user.Key;
                var duration = user.Value.Values.Sum();
                var ipAddres = user.Value.Keys;
                Console.WriteLine("{0}: {1} [{2}]",username, duration, string.Join(", ",ipAddres));
            }
        }

        public static void AddUsernameIP(SortedDictionary<string, SortedDictionary<string, int>> logs, string username, string ip, int count)
        {
            if (!logs[username].ContainsKey(ip))
            {
                logs[username].Add(ip, 0);
            }
            logs[username][ip] += count;
        }

        public static void AddUsername(SortedDictionary<string, SortedDictionary<string, int>> logs, string username)
        {
            if (!logs.ContainsKey(username))
            {
                logs.Add(username, new SortedDictionary<string, int>());
            }
        }
    }
}
