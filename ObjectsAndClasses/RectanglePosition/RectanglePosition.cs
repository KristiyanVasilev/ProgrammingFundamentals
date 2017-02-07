namespace RectanglePosition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RectanglePosition
    {
        static void Main()
        {
            var firstRect = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var secondRect = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var firstRectangle = new Rectangle
            {
                Left = firstRect[0],
                Top = firstRect[1],
                Width = firstRect[2],
                Height = firstRect[3]
            };

            var secondRectangle = new Rectangle
            {
                Left = secondRect[0],
                Top = secondRect[1],
                Width = secondRect[2],
                Height = secondRect[3]
            };
            var result = CalculatePosition(firstRectangle, secondRectangle);
            if (result)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
            
        }

        public static bool CalculatePosition(Rectangle firstRectangle, Rectangle secondRectangle)
        {
           var leftIsCorrect = firstRectangle.Left >= secondRectangle.Left;
            var rightIsCorrect = firstRectangle.Right <= secondRectangle.Right;
            var topIsCorrect = firstRectangle.Top <= secondRectangle.Top;
            var bottomIsCorrect = firstRectangle.Bottom >= secondRectangle.Bottom;

            return leftIsCorrect && rightIsCorrect && topIsCorrect && bottomIsCorrect;
        }
    }
}
