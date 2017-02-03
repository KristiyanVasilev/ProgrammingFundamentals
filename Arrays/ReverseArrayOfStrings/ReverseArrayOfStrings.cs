namespace ReverseArrayOfStrings
{
    using System;
    using System.Linq;

    class ReverseArrayOfStrings
    {
        static void Main()
        {
                
            //string[] trimedInput = input.Split(' ');
            var reverseString = new string[input.Length];

            for (int i = 0; i <= input.Length - 1; i++)
            {
                reverseString[i] = input[input.Length - 1 - i];
            }
            Console.WriteLine(string.Join(" ", reverseString));
           
        }
    }
}
