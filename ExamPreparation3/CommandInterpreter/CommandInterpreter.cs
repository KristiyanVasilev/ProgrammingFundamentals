namespace CommandInterpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CommandInterpreter
    {
        public static void Main()
        {
            var arrString = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var line = Console.ReadLine();
            while (line != "end")
            {
                var instructions = line.Split();
                var command = instructions[0];
                switch (command)
                {
                    case "reverse":
                        var start = int.Parse(instructions[2]);
                        var count = int.Parse(instructions[4]);
                        if (IsValid(arrString, start, count))
                        {
                            Reverse(arrString, start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "sort":
                        start = int.Parse(instructions[2]);
                        count = int.Parse(instructions[4]);
                        if (IsValid(arrString, start, count))
                        {
                            Sort(arrString, start, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollLeft":
                        count = int.Parse(instructions[1]);
                        if (count >= 0)
                        {
                            RollLeft(arrString, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;

                    case "rollRight":
                        count = int.Parse(instructions[1]);
                        if (count >= 0)
                        {
                            RollRight(arrString, count);
                        }
                        else
                        {
                            Console.WriteLine("Invalid input parameters.");
                        }
                        break;
                }
                line = Console.ReadLine();
            }
            Console.WriteLine("[" + string.Join(", ", arrString) + "]");
        }

        public static void RollRight(List<string> arrString, int count)
        {
            count = count % arrString.Count;
            for (int i = 0; i < count; i++)
            {
                var lastElement = arrString[arrString.Count - 1];
                arrString.RemoveAt(arrString.Count - 1);
                arrString.Insert(0, lastElement);
            }
        }

        public static void RollLeft(List<string> arrString, int count)
        {
            count = count % arrString.Count;
            for (int i = 0; i < count; i++)
            {
                var firstElement = arrString[0];
                for (int j = 0; j < arrString.Count - 1; j++)
                {
                    arrString[j] = arrString[j + 1];
                }
                arrString[arrString.Count - 1] = firstElement;
            }
            //The code below is too slow

            //for (int i = 0; i < count; i++)
            //{
            //    var element = arrString[0];
            //    arrString.RemoveRange(0, 1);
            //    arrString.Insert(arrString.Count, element);
            //}
        }

        public static void Sort(List<string> arrString, int start, int count)
        {
            //arrString.Sort(start, count, StringComparer.InvariantCulture);
            var resultList = arrString.Skip(start).Take(count).OrderBy(a => a).ToList();
            arrString.RemoveRange(start, count);
            arrString.InsertRange(start, resultList);
        }

        public static void Reverse(List<string> arrString, int start, int count)
        {
            //var resultList = arrString.Skip(start).Take(count).Reverse().ToList();
            //arrString.RemoveRange(start, count);
            //arrString.InsertRange(start, resultList);
            arrString.Reverse(start, count);
        }

        public static bool IsValid(List<string> arrString, int start, int count)
        {
            var arrLen = arrString.Count;
            if (start >= 0 && start < arrLen && count >= 0 && (count + start) <= arrLen)
            {
                return true;
            }
            return false;
        }
    }
}
