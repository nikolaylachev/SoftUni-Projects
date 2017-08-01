using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Minimum_Abs_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            int minDifference = a[0] + a[1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((Math.Abs(a[i]-a[j]) < minDifference) && i!=j)
                    {
                        minDifference = Math.Abs(a[i] - a[j]);
                    }
                }
            }
            Console.WriteLine(minDifference);
        }
    }
}
