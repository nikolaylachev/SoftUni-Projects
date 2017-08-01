using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Sherlock_and_Cost
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] arr = { 2, 4, 3 };
            int sum = 0;
            int bestSum = 0;
            int counter = 0;
            for (int arr0_i = 1; arr0_i <= arr[0]; arr0_i++)
            {
                for (int j = 1; j <= arr[1]; j++)
                {
                    for (int k = 1; k <=arr[2]; k++)
                    {
                        counter++;
                        sum += Math.Abs(j - arr0_i) + Math.Abs(k - j);
                        Console.WriteLine("{0} {1} {2} ", arr0_i, j, k);
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                        }
                        sum = 0;
                    }
                }
            }
            Console.WriteLine("bestSum = {0}, counter = {1}",bestSum,counter);*/

            int[] B = { 2, 4, 3 };
            int combinations = 1;

            for (int i = 0; i < B.Length; i++)
            {
                combinations *= B[i];
            }

            Console.WriteLine("Combinations = {0}",combinations);

            string str = string.Empty;

            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 1; j <= B[i]; j++)
                {
                    Console.Write("{0} ",j);
                    str += j;
                }
                Console.WriteLine();
            }

            for (int i = 0; i < str.Length; i++)
            {
                Console.Write("{0} ",str[i]);
            }
        }
    }
}
