using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();// 4 2 8 6
            int a = arr[0];
            int b = arr[0];
            int c = arr[0];
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                a = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    b = arr[j];
                    for (int k = 0; k < arr.Length; k++)
                    {
                        c = arr[k];
                        if ((i < j) && (a + b == c))
                        {
                            Console.WriteLine($"{a} + {b} == {c}");
                            counter++;
                        }
                    }

                }
            }

           // Console.WriteLine(counter);

            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
