namespace SrabskoUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
           
            while (input != "End")
            {
                var line = input.Split('@').ToString();
                var singerName = line[0];
                var venueTicketsAndPrice = line[1];


            }
        }
    }
}
