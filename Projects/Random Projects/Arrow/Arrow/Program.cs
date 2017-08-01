using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrow
{
    class Program
    {
        //A function that does the same as new string but works with strings and single characters!
        static void PrintStringNTimes(string s1, int size)
        {
            for (int i = 1; i <= size; i++)
            {
                Console.Write(s1);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfDots = 1,numberOfSpaces=2*n;
            
            for (int i = 1; i < n; i++)
            {
                Console.Write(new string(' ',numberOfSpaces));
                Console.WriteLine(new string('*',numberOfDots));
                numberOfDots++;
            }
            Console.Write(new string('*',numberOfSpaces));
            Console.WriteLine(new string('*',numberOfSpaces/2));
            numberOfDots = n - 1;
            for (int i = n-1; i >= 1; i--)
            {
                Console.Write(new string(' ', numberOfSpaces));
                Console.WriteLine(new string('*', numberOfDots));
                numberOfDots--;
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                PrintStringNTimes("* ", i);
            }
        }
    }
}
