namespace CharityMarathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainClass
    {
        public static void Main()
        {
            var days = decimal.Parse(Console.ReadLine());
            var runners = decimal.Parse(Console.ReadLine());
            var averageNumOfLaps = decimal.Parse(Console.ReadLine());
            var trackLenght = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var maximumRunners = trackCapacity * days;
            if (runners < maximumRunners)
            {
                maximumRunners = runners;
            }
            var totalKilometers = (trackLenght * maximumRunners * averageNumOfLaps) / 1000;
            var totalMoney = totalKilometers * moneyPerKm;
            Console.WriteLine($"Money raised: {totalMoney:f2}");
        }
    }
}
