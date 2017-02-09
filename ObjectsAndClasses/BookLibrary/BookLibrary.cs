namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            var result = new SortedDictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var book = new Book
                {
                    Title = line[0],
                    Author = line[1],
                    Publisher = line[2],
                    ReleaseDate = line[3],
                    ISBN = line[4],
                    Price = decimal.Parse(line[5])
                };

                books.Add(book);
                if (!result.ContainsKey(book.Author))
                {
                    result[book.Author] = 0.0m;
                }
                result[book.Author] += book.Price;

            }

            var printResult = result.OrderByDescending(x => x.Value);

            foreach (var authorsName in printResult)
            {
                Console.WriteLine($"{authorsName.Key:f2} -> {authorsName.Value:f2}");
            }
        }
    }
}
