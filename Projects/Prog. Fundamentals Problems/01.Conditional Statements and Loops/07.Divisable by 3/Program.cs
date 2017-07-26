using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Divisable_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 1;
            for (int i = 1; i <= n; i++)
            {
                if (counter%2==1)
                {
                    Console.WriteLine(counter);
                    sum += counter;
                    counter += 2; 
                }
            }
            Console.WriteLine($"Sum: {sum}");
       
        }
    }
}
