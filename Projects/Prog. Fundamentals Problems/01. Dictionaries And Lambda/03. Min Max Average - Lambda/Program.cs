using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;//Now we can use Console.Read/WriteLine without Console!!!
namespace _03.Min_Max_Average___Lambda
{
    class Program
    {
        //static int Max(int a, int b)
        //{
        //    (a > b) ? a : b
        //}
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            List<int> numbersList = new List<int>(n);
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(ReadLine());
            }
            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");


        }
    }
}
