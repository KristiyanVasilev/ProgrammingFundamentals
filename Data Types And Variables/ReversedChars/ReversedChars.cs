﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversedChars
{
    class ReversedChars
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char thirdLetter = char.Parse(Console.ReadLine());

            Console.Write(thirdLetter);
            Console.Write(secondLetter);
            Console.Write(firstLetter);
            Console.WriteLine();
        }
    }
}