namespace CompareCharArrays
{
    using System;
    using System.Linq;

    class CompareCharArrays
    {
        static void Main()
        {
            var firstInput = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var secondInput = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int end = Math.Min(firstInput.Length, secondInput.Length);
            bool equal = true;
            bool firstGreater = false;
            bool secondGreater = false;

            for (int i = 0; i < end; i++)
            {
                if (firstInput[i] == secondInput[i])
                {
                    continue;
                }
                else
                {
                    if ((int) firstInput[i] < (int) secondInput[i])
                    {
                        firstGreater = true;
                    }
                    else
                    {
                        secondGreater = true;
                    }
                    equal = false;
                    break;                 
                }
            }

            if (equal)
            {
                if (firstInput.Length < secondInput.Length)
                {
                    foreach (var letter in firstInput)
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();

                    foreach (var letter in secondInput)
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();
                }
                else
                {
                    foreach (var item in secondInput)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    foreach (var item in firstInput)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                if (firstGreater)
                {
                    foreach (var letter in firstInput)
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();

                    foreach (var letter in secondInput)
                    {
                        Console.Write(letter);
                    }
                    Console.WriteLine();
                }
                if (secondGreater)
                {
                    foreach (var item in secondInput)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    foreach (var item in firstInput)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                }               
            }       
        }
    }
}
