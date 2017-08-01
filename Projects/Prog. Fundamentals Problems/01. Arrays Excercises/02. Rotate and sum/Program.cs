using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_sum
{
    class Program
    {
        static int [] RightRotationOfArray(int [] arr)
        {
            int[] rightRotatedArray = new int[arr.Length];

            int copyOfFirstElement = arr[arr.Length-1];
            for (int i = 1; i < arr.Length; i++)
            {
                rightRotatedArray[i] = arr[i - 1];
            }
            rightRotatedArray[0] = copyOfFirstElement;

            return rightRotatedArray;
        }

        static void Main(string[] args)
        {
            // int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] rightArray = new int[arr.Length];//RightRotationOfArray(arr);
            int[] newArray = new int[arr.Length];
            
            for (int i = 1; i <= k; i++)
            {
                rightArray = RightRotationOfArray(arr);
                arr = rightArray;
                for (int j = 0; j < arr.Length; j++)
                {
                    newArray[j] = newArray[j] + arr[j];
                }
                //arr = newArray;
            }
            for (int i = 0; i < rightArray.Length; i++)
            {
                Console.Write($"{newArray[i]} ");
            }

        }
    }
}
