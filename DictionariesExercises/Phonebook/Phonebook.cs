namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Phonebook
    {
        public static void Main()
        {
            var input = new List<string>();
            var phonebook = new Dictionary<string, string>();
            do
            {
                input = Console.ReadLine().Split(' ').ToList();
                if (input[0] == "A")
                {
                    //phonebook.Add(input[1], input[2]);
                    phonebook[input[1]] = input[2];
                }
                else if (input[0] == "S" && !phonebook.ContainsKey(input[1]))
                {
                    Console.WriteLine("Contact {0} does not exist.", input[1]);
                }
                else if (input[0] == "S" && phonebook.ContainsKey(input[1]))
                {

                    foreach (var name in phonebook)
                    {
                        if (name.Key == input[1])
                        {
                            Console.WriteLine($"{name.Key} -> {name.Value}");
                        }
                    }
                }
            } while (input[0] != "END");


        }
    }
}
