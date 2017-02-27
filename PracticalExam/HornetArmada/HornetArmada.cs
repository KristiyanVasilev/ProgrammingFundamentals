namespace HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetArmada
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var legions = new Dictionary<string, Legion>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = int.Parse(line[0]);
                var legionName = line[1];
                var soldierType = line[2];
                var soldierCount = int.Parse(line[3]);

                if (!legions.ContainsKey(legionName))
                {
                    legions[legionName] = new Legion()
                    {
                        Activity = 0,
                        SoldierType = new Dictionary<string, int>()
                    };
                }
                if (!legions[legionName].SoldierType.ContainsKey(soldierType))
                {
                    legions[legionName].SoldierType.Add(soldierType, soldierCount);
                    if (legions[legionName].Activity < lastActivity)
                    {
                        legions[legionName].Activity = lastActivity;
                    }
                }
                else
                {
                    legions[legionName].SoldierType[soldierType] += soldierCount;
                    if (legions[legionName].Activity < lastActivity)
                    {
                        legions[legionName].Activity = lastActivity;
                    }
                }

            }
            var query = Console.ReadLine();
            var queryActivity = 0;
            var querySoldierType = string.Empty;
            if (query.Contains("\\"))
            {
                var queries = query.Split('\\');
                queryActivity = int.Parse(queries[0]);
                querySoldierType = queries[1];
                var result = legions.Values[querySoldierType];

                foreach (var item in result)
                {

                }

                //foreach (var legion in result.OrderByDescending(l => l.Value.SoldierType.Values.Sum()))
                //{
                //    if (legion.Value.Activity < queryActivity)
                //    {
                       
                //    }
                //}
            }
            else
            {
                querySoldierType = query;
                foreach (var legion in legions.OrderByDescending(a => a.Value.Activity))
                {
                    if (legion.Value.SoldierType.ContainsKey(querySoldierType))
                    {
                        Console.WriteLine($"{legion.Value.Activity} : {legion.Key}");
                    }
                }
            }
        }

        public class Legion
        {
            public int Activity { get; set; }
            public Dictionary<string, int> SoldierType { get; set; }
            //public int SoldierCount { get; set; }
        }
    }
}

