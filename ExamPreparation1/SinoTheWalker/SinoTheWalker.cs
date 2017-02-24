namespace SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var startingTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            var steps = long.Parse(Console.ReadLine());
            var stepsPerSecond = long.Parse(Console.ReadLine());
            var secondsToAdd = steps * stepsPerSecond;
            
            var startHours = startingTime[0];
            var startMinutes = startingTime[1];
            var startSeconds = startingTime[2];
            var totalStartingSeconds = (startHours * 60 * 60) + (startMinutes * 60) + startSeconds;
            var totalSeconds = totalStartingSeconds + secondsToAdd;

            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;
            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
