using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ',n-i));
                for (int col = 1; col <= i; col++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                for (int col = 1; col <= i; col++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int numberOfSpaces = n-2;
            int numberOfStars = ((n - numberOfSpaces)/2)+1;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}",new string(' ',numberOfSpaces),new string('*',numberOfStars),new string(' ',numberOfSpaces));
            }



        }
    }
}
