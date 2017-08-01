using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5_Diamond_17._07._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfLRDots = n;
            int numberOfMiddleDots = (5 * n) - (2 * n) - 2;
            for (int i = 1; i <= n; i++)
            {
                if (i==1)
                {
                    Console.WriteLine("{0}*{1}*{2}",new string('.',numberOfLRDots), new string('*',numberOfMiddleDots), new string('.',numberOfLRDots));
                }
                else if (i>1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('.',numberOfLRDots), new string('.',numberOfMiddleDots), new string('.',numberOfLRDots));
                }
                numberOfLRDots--;
                numberOfMiddleDots+=2;
            }

            for (int i = 1; i <= 1; i++)
            {
                Console.WriteLine(new string('*',5*n));
            }

            numberOfLRDots = 1;
            numberOfMiddleDots = (5 * n) - 4;
            for (int i = 1; i <= (2*n)+1; i++)
            {
                if (i < (2*n)+1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('.', numberOfLRDots), new string('.', numberOfMiddleDots), new string('.', numberOfLRDots)); 
                }
                if (i == (2*n)+1)
                {
                    Console.WriteLine("{0}*{1}*{2}", new string('.',numberOfLRDots), new string('*',numberOfMiddleDots), new string('.',numberOfLRDots));
                }
                numberOfLRDots++;
                numberOfMiddleDots -= 2;
            }
        }
    }
}
