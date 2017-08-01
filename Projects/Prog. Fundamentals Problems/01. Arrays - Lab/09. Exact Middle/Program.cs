using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Exact_Middle
{
    class Program
    {
        //Console.WriteLine(string.Join(" ", arr));
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr2 = new int [2];
            int[] arr3 = new int[3];
            if (arr.Length == 1)
            {
                Console.WriteLine(" {0} ",arr[0]);
            }
            else if (arr.Length % 2 == 0 && arr.Length > 1)//even - > 2 elements
            {
                arr2[0] = arr[(arr.Length / 2) - 1];
                arr2[1] = arr[arr.Length / 2];

                Console.WriteLine(string.Join(", ",arr2));
            }
            else if (arr.Length % 2 == 1 && arr.Length > 1)//odd - > 3 elements
            {
                arr3[0] = arr[(arr.Length / 2) - 1];
                arr3[1] = arr[(arr.Length / 2)];
                arr3[2] = arr[(arr.Length / 2) + 1];
                Console.WriteLine(string.Join(", ",arr3));
            }
        }
    }
}
