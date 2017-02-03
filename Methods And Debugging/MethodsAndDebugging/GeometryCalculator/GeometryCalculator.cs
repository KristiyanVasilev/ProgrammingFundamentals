using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string parameter = Console.ReadLine().ToLower();
            double side = double.Parse(Console.ReadLine());

            switch (parameter)
            {
                case "triangle":
                    double height = double.Parse(Console.ReadLine());
                    Triangle(side, height);
                    break;
                case "square":
                    Square(side);
                    break;
                case "rectangle":
                    double height2 = double.Parse(Console.ReadLine());
                    Rectangle(side, height2);
                    break;
                case "circle":
                    Circle(side);
                    break;
            }
        }
        public static void Triangle(double side, double height)
        {
            Console.WriteLine("{0:f2}", (side * height) / 2);
        }
        public static void Square(double side)
        {
            Console.WriteLine("{0:f2}", side * side);
        }
        public static void Rectangle(double width, double height)
        {
            Console.WriteLine("{0:f2}", width * height);
        }
        public static void Circle(double radius)
        {
            Console.WriteLine("{0:f2}", Math.PI * (radius * radius));
        }
    }
}
