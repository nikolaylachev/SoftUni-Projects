using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fake_Advertisment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.",
                "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phrasesIndexer = new Random();
            
            Random eventsIndexer = new Random(events.Length);
           
            Random authorsIndexer = new Random(authors.Length);
           
            Random citiesIndexer = new Random(cities.Length);
            

            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int phrasesIndexerInt = phrasesIndexer.Next(phrases.Length);
                int eventsIndexerInt = eventsIndexer.Next(events.Length);
                int authorsIndexerInt = authorsIndexer.Next(authors.Length);
                int citiesIndexerInt = citiesIndexer.Next(cities.Length);
                Console.WriteLine($"{phrases[phrasesIndexerInt]} {events[eventsIndexerInt]} {authors[authorsIndexerInt]} - {cities[citiesIndexerInt]}");
            }
        }
    }
}
