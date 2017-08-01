using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            byte n = byte.Parse(Console.ReadLine());
            string word = string.Empty;
            string combination = string.Empty;
           
            if (oddOrEven == "even")
            {
                for (byte i = 1; i <= n; i++)
                {
                    word = Console.ReadLine();
                    if (i % 2 == 0)
                    {
                        combination += (word + delimiter); 
                    }
                }

                
            }
            else if (oddOrEven == "odd")
            {
                for (byte i = 1; i <= n; i++)
                {
                    word = Console.ReadLine();
                    if (i % 2 == 1)
                    {
                       combination += (word + delimiter); 
                    }
                }
            }
            Console.WriteLine(combination.Remove(combination.Length-1));
        }
    }
}
