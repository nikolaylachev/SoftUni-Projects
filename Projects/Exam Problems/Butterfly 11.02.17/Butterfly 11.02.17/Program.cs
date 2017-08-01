using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly_11._02._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.Write(new string('*', n - 2));
            Console.Write(new string('\\', 1));
            Console.Write(new string(' ', 1));
            Console.Write(new string('/', 1));
            Console.WriteLine(new string('*', n - 2));

            //Top middle
            for (int i = 1; i < (n / 2); i++)//;i <= (n/2) - 1; is also exceptable
            {
                Console.Write(new string('-', n - 2));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('/', 1));
                Console.WriteLine(new string('-', n - 2));

                Console.Write(new string('*', n - 2));
                Console.Write(new string('\\', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('/', 1));
                Console.WriteLine(new string('*', n - 2));
            }

            //Middle
            Console.Write(new string(' ', n - 1));
            Console.WriteLine(new string('@', 1));

            //Bottom middle
            for (int i = 1; i <= (n / 2 - 1); i++)//;i< (n / 2);//Also exceptable
            {
                Console.Write(new string('*', n - 2));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('\\', 1));
                Console.WriteLine(new string('*', n - 2));

                Console.Write(new string('-', n - 2));
                Console.Write(new string('/', 1));
                Console.Write(new string(' ', 1));
                Console.Write(new string('\\', 1));
                Console.WriteLine(new string('-', n - 2));
            }
            //Bottom
            Console.Write(new string('*', n - 2));
            Console.Write(new string('/', 1));
            Console.Write(new string(' ', 1));
            Console.Write(new string('\\', 1));
            Console.WriteLine(new string('*', n - 2));
        }
    }
}
