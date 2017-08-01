using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Book_Library
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
            List<Book> books = new List<Book>();//Book[] books = new Book[n];
            
            for (int i = 0; i < n; i++)
            {
                command = Console.ReadLine().Split(' ').ToList();

                string[] date = command[3].Split('.');
                DateTime newDate = new DateTime(int.Parse(date[2]),int.Parse(date[1]),int.Parse(date[0]));

                books.Add(new Book() { Title = command[0], Author = command[1],
                Publisher = command[2], ReleaseDate = newDate,
                ISBN = command[4], Price = decimal.Parse(command[5]), });
                //books[i] = new Book()
                //{
                //    Title = command[0],
                //    Author = command[1],
                //    Publisher = command[2],
                //    ReleaseDate = newDate,
                //    ISBN = command[4],
                //    Price = decimal.Parse(command[5]),
                //};
            }

            Library library = new Library() { Name = "Library", Books = books };
            Dictionary<string, decimal> totalSumsOfAuthors = new Dictionary<string, decimal>();
            decimal sum = 0M;

            for (int i = 0; i < books.Count; i++)
            {
                if (totalSumsOfAuthors.ContainsKey(books[i].Author))
                {
                    sum += books[i].Price;
                    totalSumsOfAuthors[(books[i].Author.ToString())] += sum;
                    sum = 0M;
                }
                else if (! totalSumsOfAuthors.ContainsKey(books[i].Author))
                {
                    sum += books[i].Price;
                    totalSumsOfAuthors[(books[i].Author.ToString())] = sum;
                    sum = 0M;
                }
            }
            var newDict = totalSumsOfAuthors.OrderBy(x => -x.Value).ThenBy(x => x.Key);
            foreach (var item in newDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }
        }
    }
}
