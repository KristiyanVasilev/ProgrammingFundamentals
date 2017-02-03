using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertSpeedUnits
{
    class ConvertSpeedUnits
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minuts = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            float totalTime = (hours * 3600) + (minuts * 60) + seconds;
            float mps = meters / totalTime;
            float kph = (meters / 1000) / (totalTime / 3600);
            float mph = kph / 1.609f;
            Console.WriteLine(mps);
            Console.WriteLine(kph);
            Console.WriteLine(mph);
        }
    }
}
