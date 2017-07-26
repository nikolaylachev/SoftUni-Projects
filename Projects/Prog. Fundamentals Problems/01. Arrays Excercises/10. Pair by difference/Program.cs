using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pair_by_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairsCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if ((Math.Abs(arr[i]-arr[j]) == difference))
                    {
                        pairsCounter++;
                    }
                }
            }
            Console.WriteLine(pairsCounter);
        }
    }
}
