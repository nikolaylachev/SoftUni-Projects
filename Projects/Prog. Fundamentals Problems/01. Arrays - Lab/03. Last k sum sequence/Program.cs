using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_k_sum_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] seq = new int[n];
            int sum = 0; 
            seq[0] = 1;
            for (int i = 1; i < n; i++)
            {
                for (int j = i; j <=k ; j++)
                {

                }
            }
        }
    }
}
