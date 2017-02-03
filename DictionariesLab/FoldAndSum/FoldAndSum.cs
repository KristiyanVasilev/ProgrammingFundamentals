namespace FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FoldAndSum
    {
        static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int k = inputNums.Length / 4;
            var firstRowLeft = inputNums.Take(k).Reverse().ToArray();
            var firstRowRight = inputNums.Reverse().Take(k).ToArray();
            var firstRow = firstRowLeft
                .Concat(firstRowRight);
            var secondRow = inputNums
                .Skip(k)
                .Take(2 * k)
                .ToArray();
            var result = firstRow
                .Zip(secondRow, (x, y) => x + y);
            Console.WriteLine(string.Join(" ", result));        
        }
    }
}
