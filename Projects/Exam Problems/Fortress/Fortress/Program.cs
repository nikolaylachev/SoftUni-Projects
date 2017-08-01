using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            int n = int.Parse(Console.ReadLine());
            int numberOfArrows = n / 2;
            int numberOfDashes = ((2 * n) - 4) - ((n / 2) * 2);
            //Top
            Console.Write("/");
            Console.Write(new string('^',numberOfArrows));
            Console.Write("\\");
            Console.Write(new string('_', numberOfDashes));
            Console.Write("/");
            Console.Write(new string('^', numberOfArrows));
            Console.WriteLine("\\");

            //Middle
            for (int i = 1; i <= n-3; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ',(2*n)-2));
                Console.WriteLine("|");
            }
            //Beforelast row
            int numberOfSpaces = (((2*n) - 2) - numberOfDashes)/2;
            Console.Write("|");
            Console.Write(new string(' ',numberOfSpaces));
            Console.Write(new string('_',numberOfDashes));
            Console.Write(new string(' ',numberOfSpaces));
            Console.WriteLine("|");

            //Bottom
            Console.Write("\\");
            Console.Write(new string('_',n/2));
            Console.Write("/");
            Console.Write(new string(' ',numberOfDashes));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
