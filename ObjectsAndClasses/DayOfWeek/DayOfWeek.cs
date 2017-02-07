namespace DayOfWeek
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;

    class MainClass
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            DateTime date = DateTime.ParseExact(input, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
