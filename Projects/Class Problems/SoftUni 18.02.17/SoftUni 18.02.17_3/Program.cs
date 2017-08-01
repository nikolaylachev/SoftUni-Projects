using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Еnter a number in the range [1...100]: ");
                number = int.Parse(Console.ReadLine());
                if (number>=1 && number<=100)
                {
                    Console.WriteLine("The number is: {0}", number);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            while (number < 1 || number > 100);
        }
    }
}
