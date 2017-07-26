using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingCharacter = int.Parse(Console.ReadLine());
            int endingCharacter = int.Parse(Console.ReadLine());
            for (int i = startingCharacter; i <= endingCharacter; i++)
            {
                Console.Write($"{(char)i} ");
            }

        }
    }
}
