using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Make_a_word
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            byte n = byte.Parse(Console.ReadLine());
            for (byte i = 1; i <= n; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                word += ch;
            }
            Console.WriteLine($"The word is: {word}");
        }
    }
}
