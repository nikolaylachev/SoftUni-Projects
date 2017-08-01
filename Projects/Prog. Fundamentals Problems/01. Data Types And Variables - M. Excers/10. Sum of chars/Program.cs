using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Sum_of_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n = byte.Parse(Console.ReadLine());
            long sum = 0;
            for (byte i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                sum += (long)ch;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
