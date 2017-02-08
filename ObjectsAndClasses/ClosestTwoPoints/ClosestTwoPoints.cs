namespace ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestTwoPoints
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var points = new List<Point>();

            for (int i = 0; i < number; i++)
            {
                var line = Console.ReadLine().Split().Select(double.Parse).ToList();
                var currentPoint = new Point
                {
                    X = line[0],
                    Y = line[1]
                };

                points.Add(currentPoint);
            }     
                var minDistance = 0.0;
                Point firstPointMin = null;
                Point secondPointMin = null;

                for (int s = 0; s < points.Count - 1; s++)
                {
                    for (int j = s + 1; j < points.Count; j++)
                    {
                        var firstPoint = points[s];
                        var secondPoint = points[j];
                        var currentDistance = CalculateDistance(firstPoint, secondPoint);
                        if (currentDistance < minDistance)
                        {
                            minDistance = currentDistance;
                            firstPointMin = firstPoint;
                            secondPointMin = secondPoint;
                        }
                    }              
                }
            Console.WriteLine($"{minDistance}");
            Console.WriteLine($"{firstPointMin.X}, {firstPointMin.Y}");
            Console.WriteLine($"{secondPointMin.X}, {secondPointMin.Y}");
        }
        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;
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
