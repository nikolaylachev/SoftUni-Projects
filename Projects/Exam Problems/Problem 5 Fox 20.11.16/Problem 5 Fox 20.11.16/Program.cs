using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Fox_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfLRStars = 1;
            int numberOfMiddleDashes = ((2 * n) + 3) - 4;
            //Top
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}",new string('*',numberOfLRStars), new string('-',numberOfMiddleDashes), new string('*',numberOfLRStars));
                numberOfLRStars++;
                numberOfMiddleDashes -= 2;
            }

            //Middle
            numberOfLRStars = n / 2;
            int numberOfMiddleStars = ((2 * n) + 3) - (2 * (n / 2)) - 4;
            for (int i = 1; i <= n/3; i++)
            {
                Console.WriteLine("|{0}\\{1}/{2}|", new string('*',numberOfLRStars), new string('*',numberOfMiddleStars), new string('*',numberOfLRStars));
                numberOfLRStars++;
                numberOfMiddleStars -= 2;
            }

            //Bottom
            numberOfLRStars = 1;
            numberOfMiddleDashes = ((2 * n) + 3) - 4;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("{0}\\{1}/{2}", new string('-', numberOfLRStars), new string('*', numberOfMiddleDashes), new string('-', numberOfLRStars));
                numberOfLRStars++;
                numberOfMiddleDashes -= 2;
            }
        }
    }
}
