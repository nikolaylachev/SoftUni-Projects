using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int [] leftArray = new int[arr.Length/4];
            int[] rightArray = new int[arr.Length / 4];
            int[] leftRightArray = new int[leftArray.Length + rightArray.Length];

            for (int i = 0; i < (arr.Length/4); i++)
            {
                leftArray[i] = arr[i];
            }
            for (int i = ((arr.Length/4) + (arr.Length/2)),j=0; i < arr.Length; i++,j++)
            {
                rightArray[j] = arr[i];
            }

            Array.Reverse(leftArray);
            Array.Reverse(rightArray);

            for (int i = arr.Length/4,j=0; i < arr.Length/2; i++,j++)
            {
                arr[i] = arr[i] + leftArray[j];
            }

            for (int i = arr.Length / 2, j = 0; i < (arr.Length / 2 + rightArray.Length); i++, j++)
            {
                arr[i] = arr[i] + rightArray[j];
                //Console.WriteLine(arr[i]);
            }
            for (int i = arr.Length / 4, j = 0; i < arr.Length / 2; i++, j++)
            {
                Console.Write($"{arr[i]} ");
            }
            for (int i = arr.Length / 2; i < (arr.Length / 2 + rightArray.Length); i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
    }
}
