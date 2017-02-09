namespace AdvertismentMessage
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class MainClass
    {
        public static void Main()
        {
            var input = int.Parse(Console.ReadLine());

            var phrases = new List<string>();
            phrases.Add("Excellent product.");
            phrases.Add("Such a great product.");
            phrases.Add("I always use that product.");
            phrases.Add("Best product of its category.");
            phrases.Add("Exceptional product.");
            phrases.Add("I can’t live without this product.");

            var events = new List<string>();
            events.Add("Now I feel good.");
            events.Add("I have succeeded with this product");
            events.Add("Makes miracles. I am happy of the results!");
            events.Add("I cannot believe but now I feel awesome.");
            events.Add("Try it yourself, I am very satisfied.");
            events.Add("I feel great!");

            var author = new List<string>();
            author.Add("Diana");
            author.Add("Eva");
            author.Add("Petya");
            author.Add("Stella");
            author.Add("Elena");
            author.Add("Katya");
            author.Add("Iva");
            author.Add("Annie");

            var town = new List<string>();
            town.Add("Burgas");
            town.Add("Sofia");
            town.Add("Plovdiv");
            town.Add("Varna");
            town.Add("Ruse");

            var random = new Random();
            for (int i = 0; i < input; i++)
            {
                var phraseIndex = random.Next(0, phrases.Count);
                var eventIndex = random.Next(0, events.Count);
                var authorIndex = random.Next(0, author.Count);
                var townIndex = random.Next(0, town.Count);

                Console.WriteLine(phrases[phraseIndex] + " " + events[eventIndex] + " " + author[authorIndex] + " - " + town[townIndex]);

            }
        }
    }
}
