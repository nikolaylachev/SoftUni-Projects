using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Debugging_Exers
{
    class Program
    {
        static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintGreeting(name);
        }
    }
}
