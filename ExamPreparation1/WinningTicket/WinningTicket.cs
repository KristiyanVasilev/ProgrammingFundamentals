using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WinningTicket
{
    public class WinningTicket
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim());

            foreach (var ticket in input)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                var left = ticket.Substring(0, 10).ToArray();
                var right = ticket.Substring(10, 10).ToArray();
                var winTicket = false;

                var leftResul = FindSymbols(left);
                if ((leftResul.Symbol == '@' || leftResul.Symbol == '#'
                    || leftResul.Symbol == '$' || leftResul.Symbol == '^') && leftResul.Count >= 6)
                {
                    var rightResult = FindSymbols(right);
                    if (leftResul.Symbol == rightResult.Symbol && rightResult.Count >= 6)
                    {
                        var jackpot = leftResul.Count == 10 && rightResult.Count == 10
                            ? "Jackpot!"
                            : string.Empty;
                        Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftResul.Count,rightResult.Count)}{rightResult.Symbol} {jackpot}");
                        winTicket = true;
                    }
                }
                if (!winTicket)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }   
            }
        }
        public class Result
        {
            public int Count { get; set; }
            public char Symbol { get; set; }
        }

        public static Result FindSymbols(char[] symbols)
        {
            var previousSymbol = symbols.First();
            int count = 0;
            int maxCount = 0;
            var maxSymbol = new char();
            for (int i = 0; i < symbols.Length; i++)
            {
                var currentSymbol = symbols[i];
                if (previousSymbol == currentSymbol)
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxSymbol = previousSymbol;
                    }
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    maxSymbol = previousSymbol;
                }
                previousSymbol = currentSymbol;
            }
            return new Result
            {
                Count = maxCount,
                Symbol = maxSymbol
            };
        }
    }
}
