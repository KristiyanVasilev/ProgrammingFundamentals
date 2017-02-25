namespace SweetDesert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SweetDesert
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = long.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriePrice = decimal.Parse(Console.ReadLine());
            var portionPrice = (2 * bananaPrice) + (4 * eggsPrice) + (berriePrice * 0.2m);
            long portions = (long)Math.Ceiling(guests / 6m);
            var totalCost = portionPrice * portions;
            if (cash >= totalCost)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalCost:F2}lv.");
            }
            else
            {
                var diff = totalCost - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:F2}lv more.");
            }            
        }
    }
}
