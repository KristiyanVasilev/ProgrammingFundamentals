namespace RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNegativesAndReverse
    {
        public static void Main()
        {
            var inputList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            inputList.RemoveAll(x => x < 0);
            inputList.Reverse();
            if (inputList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                inputList.ForEach(Console.WriteLine);
            }
            
        }
    }
}
