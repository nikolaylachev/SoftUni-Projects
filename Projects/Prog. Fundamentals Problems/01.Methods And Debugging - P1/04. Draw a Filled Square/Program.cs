using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Draw_a_Filled_Square
{
    class Program
    {
        static void PrintFirstRow(int number)
        {
            Console.WriteLine(new string('-',2*number));
        }

        static void PrintMiddleRows (int number)
        {
            int numberOfTotalSlashes = (2 * number) - 2;
           
            for(int j = 1; j < numberOfTotalSlashes/2; j++)
			{
                Console.Write(new string('-', 1));
                for (int i = 1; i <= numberOfTotalSlashes / 2; i++)
                {
                    Console.Write("\\/");
                }
                Console.WriteLine(new string('-', 1));
            }
        }

        static void PrintLastRow(int number)
        {
            Console.WriteLine(new string('-', 2 * number));
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintFirstRow(number);
            PrintMiddleRows(number);
            PrintLastRow(number);
             
        }
    }
}
