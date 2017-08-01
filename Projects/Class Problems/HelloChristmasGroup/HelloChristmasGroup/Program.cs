using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloChristmasGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            char star = '*';
            char space = ' ';
            var n = int.Parse(Console.ReadLine());


            Console.Write(new String('*',n));

            Console.WriteLine();

            for (int MiddleLoopIndex = 1; MiddleLoopIndex <= n-2; MiddleLoopIndex++)
            {

                string result = new String(space, n - 2);
                Console.WriteLine(star+result+star);

            }

            Console.Write(new String('*', n));
            Console.WriteLine();

        }
    }
}
