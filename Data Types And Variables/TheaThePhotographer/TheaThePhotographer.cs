using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            int pictureAmount = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            var filteredPics = (int)Math.Ceiling(pictureAmount * ((double)filterFactor / 100));
            var firstTime = pictureAmount * filterTime;
            var secondTime = filteredPics * uploadTime;
            var totalSec = firstTime + secondTime;

            var totalTime = new TimeSpan(0, 0, totalSec);
            //TimeSpan time = TimeSpan.FromSeconds(totalTime);
            Console.WriteLine(totalTime.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
