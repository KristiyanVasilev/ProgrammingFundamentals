namespace HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     public class HornetWings
    {
        public static void Main()
        {
            var wingFlaps = int.Parse(Console.ReadLine());
            var distanceForThousendWingFlaps = decimal.Parse(Console.ReadLine());
            var flapsBeforeBreak = int.Parse(Console.ReadLine());
            var distane = (wingFlaps / 1000m) * distanceForThousendWingFlaps;

            var seconds = wingFlaps / 100;
            var rest = (wingFlaps / flapsBeforeBreak) * 5;
            var totalSeconds = (seconds + rest);
            Console.WriteLine($"{distane:f2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
