namespace CircleIntersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CircleIntersection
    {
        static void Main()
        {
            var firstCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstCenter = new Point(firstCircleInput[0], firstCircleInput[1]);
            Point secondCenter = new Point(secondCircleInput[0], secondCircleInput[1]);

            Circle firstCircle = new Circle(firstCenter, firstCircleInput[2]);
            Circle secondCircle = new Circle(secondCenter, secondCircleInput[2]);
            if (Circle.Intersect(firstCircle, secondCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
