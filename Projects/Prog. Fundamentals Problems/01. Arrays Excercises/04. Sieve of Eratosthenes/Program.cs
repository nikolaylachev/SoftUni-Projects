using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sieve_of_Eratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<int> NoPrime = new HashSet<int>();

            long count = 0;
            //int n = 2000000;

            for (int x = 2; x < n; x++)
            {
                for (int y = x * 2; y < n; y = y + x)
                {

                    if (!NoPrime.Contains(y))
                    {
                        NoPrime.Add(y);
                    }

                }

            }

            for (int z = 2; z < n; z++)
            {
                if (!NoPrime.Contains(z))
                {
                    Console.Write($"{z} ");
                    count = count + z;
                }
            }

            //Console.WriteLine("Sum is: " + count);


        }
    }
}
