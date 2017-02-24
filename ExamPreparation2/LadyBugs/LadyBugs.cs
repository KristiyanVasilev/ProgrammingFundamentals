namespace LadyBugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MainClass
    {
        public static void Main()
        {
            var size = int.Parse(Console.ReadLine());
            var ladubygs = new int[size];
            var indexes = Console.ReadLine()
                                 .Split()
                                 .Select(int.Parse)
                                 .Where(x => x >= 0 && x < size)
                                 .ToArray();

            for (int i = 0; i < indexes.Length; i++)
            {
                var currentCell = indexes[i];
                ladubygs[currentCell] = 1;
            }

            var line = Console.ReadLine();
            while (line != "end")
            {
                var tokens = line.Split();

                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLenght = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= ladubygs.Length)
                {
                    line = Console.ReadLine();
                    continue;
                }
                if (ladubygs[ladybugIndex] == 0)
                {
                    line = Console.ReadLine();
                    continue;
                }

                MoveLadybug(ladubygs, ladybugIndex, flyLenght, direction);
                line = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", ladubygs));
        }

        public static void MoveLadybug(int[] ladubygs, int ladybugIndex, int flyLenght, string direction)
        {
            ladubygs[ladybugIndex] = 0;
            var leftArray = false;

            while (!leftArray)
            {
                switch (direction)
                {
                    case "left":
                        ladybugIndex -= flyLenght;
                        break;
                    case "right":
                        ladybugIndex += flyLenght;
                        break;
                }
                if (ladybugIndex < 0 || ladybugIndex >= ladubygs.Length)
                {
                    leftArray = true;
                    continue;
                }
                if (ladubygs[ladybugIndex] == 1)
                {
                    continue;
                }
                if (ladubygs[ladybugIndex] == 0)
                {
                    ladubygs[ladybugIndex] = 1;
                    leftArray = true;
                    continue;
                }
            }
            return;
        }
    }
}
