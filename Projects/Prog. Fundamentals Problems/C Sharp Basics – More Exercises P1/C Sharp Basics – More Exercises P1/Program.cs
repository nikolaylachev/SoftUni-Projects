using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Basics___More_Exercises_P1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfSpaces = n - 2;
            int numberOfOuterSpaces = 0;
            for (int i = 1; i <= (n/2)+1; i++)
            {
                if (numberOfSpaces >= 0)
                {
                    Console.WriteLine("{0}{1}{2}{3}{4}", new string(' ', numberOfOuterSpaces), new string('x', 1), new string(' ', numberOfSpaces), new string('x', 1), new string(' ', numberOfOuterSpaces));
                    numberOfSpaces -= 2;
                    numberOfOuterSpaces++; 
                }
                else if(numberOfSpaces <0)
                {
                    Console.WriteLine("{0}{1}{2}",new string(' ',n/2), new string('x',1), new string(' ',n/2));
                }
            }

            numberOfOuterSpaces = (n - 3) / 2;
            numberOfSpaces = 1;
            for (int i = 1; i <= n/2; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{4}", new string(' ',numberOfOuterSpaces), new string ('x',1), new string(' ',numberOfSpaces), new string('x',1), new string(' ',numberOfOuterSpaces));
                numberOfOuterSpaces--;
                numberOfSpaces += 2;
            }
        }
    }
}
