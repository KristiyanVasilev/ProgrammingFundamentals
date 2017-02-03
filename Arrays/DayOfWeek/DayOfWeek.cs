using System;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            string[] weekDay = new string[7];
            //weekDay[0] = "Invalid Day!";
            weekDay[0] = "Monday";
            weekDay[1] = "Tuesday";
            weekDay[2] = "Wednesday";
            weekDay[3] = "Thursday";
            weekDay[4] = "Friday";
            weekDay[5] = "Saturday";
            weekDay[6] = "Sunday";
            if (input < 1 || input > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(weekDay[input - 1]);
            }

        }
    }
}
