namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            var filterBooks = new SortedDictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split();
                var book = new Book
                {
                    Title = line[0],
                    Author = line[1],
                    Publisher = line[2],
                    ReleaseDate = DateTime.ParseExact(line[3], "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ISBN = line[4],
                    Price = decimal.Parse(line[5])
                };
                books.Add(book);
            }

            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InstalledUICulture);

            for (int i = 0; i < books.Count; i++)
            {
                var release = books[i].ReleaseDate;
                var title = books[i].Title;
                if (release <= endDate)
                {
                    continue;
                }
                else
                {
                    if (!filterBooks.ContainsKey(title))
                    {
                        filterBooks[title] = new DateTime();
                    }
                    filterBooks[title] = release;
                }               
            }

            var result = filterBooks.OrderBy(x => x.Value); 
            foreach (var bookTitle in result)
            {
                var date = bookTitle.Value.ToString("dd.MM.yyyy");           
                Console.WriteLine($"{bookTitle.Key} -> {date}");
            }
        }
    }
}
