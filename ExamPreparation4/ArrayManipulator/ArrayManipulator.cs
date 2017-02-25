namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ArrayManipulator
    {
        static void Main()
        {
            var array = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var line = Console.ReadLine();
            while (line != "end")
            {
                var instructions = line
                   .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var command = instructions[0];
                switch (command)
                {
                    case "exchange":
                        var index = int.Parse(instructions[1]);
                        array = ExchangeArray(array, index);
                        break;
                    case "max":
                    case "min":
                        var oddEven = instructions[1];
                        MaxMin(array, command, oddEven);
                        break;

                    case "first":
                    case "last":
                        index = int.Parse(instructions[1]);
                        oddEven = instructions[2];
                        FirstAndLast(array, command, index, oddEven);
                        break;
                }
                line = Console.ReadLine();
            }
            PrintArray(array);
        }

        private static void PrintArray(int[] array)
        {
            var arrayString = string.Join(", ", array);
            Console.WriteLine($"[{arrayString}]");
        }

        private static void FirstAndLast(int[] array, string command, int index, string oddEven)
        {
            if (index > array.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            var filter = FilterEvenOrOdd(array, oddEven);
            int[] result;

            if (command == "first")
            {
                result = filter.Take(index).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(index).ToArray();
            }
            PrintArray(result);
        }

        private static void MaxMin(int[] array, string command, string oddEven)
        {
            var filter = FilterEvenOrOdd(array, oddEven);

            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }
            var result = command == "max" ? filter.Max() : filter.Min();
            Console.WriteLine(Array.LastIndexOf(array, result));
        }

        private static int[] FilterEvenOrOdd(int[] array, string oddEven)
        {
            return array
                 .Where(n => oddEven == "even"
                 ? n % 2 == 0
                 : n % 2 == 1)
                 .ToArray();
        }

        private static int[] ExchangeArray(int[] array, int index)
        {
            if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Invalid index");
                return array;
            }
            else
            {
                var left = array.Take(index + 1);
                var right = array.Skip(index + 1);
                return right.Concat(left).ToArray();
            }
        }
    }
}
