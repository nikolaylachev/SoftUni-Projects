using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan_s_Problem_Mixing_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int a = 0, b = 0, c = 0, d = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n-1; i++)//
            {
                //a = numbers[i] / 10;// Getting the first digit of the i-th element.(NOT NEEDED!)
                b = numbers[i] % 10;//Getting the second digit of the i-th element.
                c = numbers[i + 1] / 10;//Getting the first digit of the next element.
                //d = numbers[i + 1] % 10; Getting the second digit of the next element.(NOT NEEDED!)
                Console.Write("{0} ",(b*c));
            }
            Console.WriteLine();
            for (int i = 0; i < n-1; i++)
            {
                Console.Write("{0} ",(Math.Abs(numbers[i]-numbers[i+1])));
            }
        }
    }
}
