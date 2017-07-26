using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Fib(int n)
        {
            int first = 0;
            int second = 1;
            int fibonacci = 1;
            for (int i = 0; i < n; i++)
            {
                fibonacci = first + second;
                first = second;
                second = fibonacci;
            }
            Console.WriteLine(fibonacci);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);
        }
    }
}
