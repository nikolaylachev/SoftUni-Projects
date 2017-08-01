using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static long Min (long[] arr)
        {
            long min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        static long Max (long [] arr)
        {
            long max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static long Sum (long [] arr)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static double Average (long [] arr)
        {
            double average = (double)Sum(arr) / arr.Length;
            return average;
        }

        static void Main(string[] args)
        {
            //
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long min = Min(arr);
            long max = Max(arr);
            long sum = Sum(arr);
            double average = Average(arr);
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
