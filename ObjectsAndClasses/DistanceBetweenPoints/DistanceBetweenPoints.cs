namespace DistanceBetweenPoints
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class DistanceBetweenPoints
    {
        public static void Main()
        {
            var firstPoint = Console.ReadLine().Split().Select(double.Parse).ToList();
            var secondPoint = Console.ReadLine().Split().Select(double.Parse).ToList();
            var first = new Point
            {
                X = firstPoint[0],
                Y = firstPoint[1]
            };
            var second = new Point
            {
                X = secondPoint[0],
                Y = secondPoint[1]
            };
            var result = CalculateDistance(first, second);
            Console.WriteLine($"{ result:F3}");
        }
        public static double CalculateDistance(Point fPoint, Point secPoint)
        {
            var diffX = fPoint.X - secPoint.X;
            var diffY = fPoint.Y - secPoint.Y;
            var powX = Math.Pow(diffX, 2);
            var powY = Math.Pow(diffY, 2);

            return Math.Sqrt(powX + powY);
        }
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }
    }    
}
