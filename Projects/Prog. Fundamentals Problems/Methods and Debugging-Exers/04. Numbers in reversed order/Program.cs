using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_reversed_order
{
    class Program
    {
        static void ReverseNumber(string number)
        {
            string reversed = string.Empty;
            for (int i = number.Length-1; i >= 0; i--) reversed += number[i];
            Console.WriteLine(reversed);
        }

        static void Main(string[] args)
        {
            //int number = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            ReverseNumber(number);
        }
    }
}
