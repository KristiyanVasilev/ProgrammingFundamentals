namespace CountWorkDays
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Globalization;

    class MainClass
    {
        public static void Main()
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var startDate = DateTime.ParseExact(firstDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(secondDate, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var holidays = new List<DateTime>()
            {   
                DateTime.ParseExact("03-03-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-05-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-05-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-05-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("06-09-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("22-09-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-11-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("24-12-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("25-12-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("01-01-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
                DateTime.ParseExact("26-12-2016","dd-MM-yyyy", CultureInfo.InvariantCulture),
            };

            var workDays = 0;
            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime checkDate = new DateTime(2016, currentDate.Month, currentDate.Day);
                bool saturday = currentDate.DayOfWeek != DayOfWeek.Saturday;
                bool sunday = currentDate.DayOfWeek != DayOfWeek.Sunday;  
                if (saturday && sunday && !holidays.Contains(checkDate))
                {
                    workDays++;
                }               
            }
            Console.WriteLine(workDays);
        }
    }
}
