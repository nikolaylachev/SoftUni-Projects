using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int copyOfI = 0;
            for (int i = 1; i <= number; i++)
            {
                copyOfI = i;
                while (copyOfI > 0)
                {
                    sum += copyOfI % 10;
                    copyOfI /= 10;
                }
                //Console.WriteLine(sum);
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
                sum = 0; 
            }
        }
    }
}
