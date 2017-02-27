namespace HornetAssaut
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetAssaut
    {
        public static void Main()
        {
            var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();
            var hornetsPower = hornets.Sum();            
            for (int i = 0; i < beehives.Count; i++)
            {
                var currentBeehavie = beehives[i];
                if (hornetsPower > currentBeehavie)
                {
                    beehives[i] = 0;
                }
                else
                {
                    beehives[i] = Math.Abs(currentBeehavie - hornetsPower);
                    hornetsPower -= hornets.First();
                    hornets.RemoveAt(0);                    
                }
            }

            var liveBees = false;
            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] != 0)
                {
                    liveBees = true;
                }
            }
            if (liveBees)
            {
                var result = beehives.Where(a => a != 0);
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
