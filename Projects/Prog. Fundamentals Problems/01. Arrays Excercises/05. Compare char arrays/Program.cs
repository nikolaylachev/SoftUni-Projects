using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_char_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            char [] arrayOfChars = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char [] arrayOfChars2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            int max = Math.Max(arrayOfChars.Length, arrayOfChars2.Length);
            int min = Math.Min(arrayOfChars.Length, arrayOfChars2.Length);
            int counter = 0;

            for (int i = 0; i < min; i++)
            {
                if (arrayOfChars[i] < arrayOfChars2[i])
                {
                    Console.WriteLine(arrayOfChars);
                    Console.WriteLine(arrayOfChars2);
                    break;
                }
                else if(arrayOfChars[i] > arrayOfChars2[i])
                {
                    Console.WriteLine(arrayOfChars2);
                    Console.WriteLine(arrayOfChars);
                    break;
                }
                else if (arrayOfChars[i] == arrayOfChars2[i])
                {
                    counter++;
                }
            }
            if (counter == min)
            {
                if (arrayOfChars.Length < arrayOfChars2.Length)
                {
                    Console.WriteLine(arrayOfChars);
                    Console.WriteLine(arrayOfChars2); 
                }
                else
                {
                    Console.WriteLine(arrayOfChars2);
                    Console.WriteLine(arrayOfChars);
                }
            }
        }
    }
}
