using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_08.Condense_array_to_number
{
    class Program
    {
        static void PrintCondenceArray (int[] arr, int sizeOfArr)
        {
            //int[] secondArr = new int[sizeOfArr - 1];
            while (sizeOfArr > 1)
            {
                int[] secondArr = new int[sizeOfArr - 1];
                //PrintCondenceArray(arr,size);
                for (int i = 0; i < sizeOfArr - 1; i++)
                {
                    secondArr[i] = arr[i] + arr[i + 1];
                }
                Console.WriteLine();
                arr = secondArr;
                for (int i = 0; i < sizeOfArr - 1; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                sizeOfArr--;
            }
            if (sizeOfArr == 1)
            {
                Console.WriteLine(arr[0]);
            }

        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            while (size > 1)
            {
                int[] secondArr = new int[size - 1];
                //PrintCondenceArray(arr,size);
                for (int i = 0; i < size - 1; i++)
                {
                    secondArr[i] = arr[i] + arr[i + 1];
                }
                //Console.WriteLine();
                arr = secondArr;
                
                size--;
            }
            for (int i = 0; i < size - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }
            if (size == 1)
            {
                Console.WriteLine(arr[0]);
            }
            
        }
    }
}
