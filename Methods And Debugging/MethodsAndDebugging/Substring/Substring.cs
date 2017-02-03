using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        char search = 'p';
        //const char Search = 'р';
        bool hasMatch = false;
        int endLoop = text.Length;
        

        for (int i = 0; i < endLoop; i++)
        {
            if (text[i] == search)
            {
                int endIndex = jump + 1;
                hasMatch = true;
                if (endIndex + i > endLoop)
                {
                    endIndex = endLoop - i;
                }            
                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i += jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
