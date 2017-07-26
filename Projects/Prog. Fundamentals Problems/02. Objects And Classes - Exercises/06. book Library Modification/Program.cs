using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.book_Library_Modification
{
    class Program
    {
        class Library
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string Publisher { get; set; }
            public DateTime ReleaseDate { get; set; }
            public string ISBN { get; set; }
            public decimal Price { get; set; }
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> command = new List<string>();
            List<Book> books = new List<Book>();

            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(' ').ToList();

                string[] date = command[3].Split('.');
                DateTime newDate = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));

                books.Add(new Book()
                {
                    Title = command[0],
                    Author = command[1],
                    Publisher = command[2],
                    ReleaseDate = newDate,
                    ISBN = command[4],
                    Price = decimal.Parse(command[5]),
                });
            }

            string[] releaseDate = Console.ReadLine().Split('.');
            DateTime releasingDate = new DateTime(int.Parse(releaseDate[2]), int.Parse(releaseDate[1]), int.Parse(releaseDate[0]));

            Dictionary<string, DateTime> bookTitlesAfterGivenDate = new Dictionary<string, DateTime>();
            for (int i = 0; i < books.Count; i++)
            {
                if (bookTitlesAfterGivenDate.ContainsKey(books[i].Title))
                {
                    bookTitlesAfterGivenDate[books[i].Title] = books[i].ReleaseDate;
                }
                else if (! bookTitlesAfterGivenDate.ContainsKey(books[i].Title))
                {
                    bookTitlesAfterGivenDate[books[i].Title] = books[i].ReleaseDate;
                }
            }

            var newDict = bookTitlesAfterGivenDate.Where(x => x.Value > releasingDate).OrderBy(x => x.Value).ThenBy(x => x.Key);

            foreach (var item in newDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:d.MM.yyyy}");
            }
        }
    }
}
