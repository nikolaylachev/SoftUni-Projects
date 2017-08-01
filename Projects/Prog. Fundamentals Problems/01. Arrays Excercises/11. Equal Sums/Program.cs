using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isEqual = false;
            if (arr.Length == 1)
            {
                Console.WriteLine("0");
            }
            else if(arr.Length > 1)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        leftSum += arr[j];
                    }

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        rightSum += arr[j];
                    }
                    if (leftSum == rightSum /*&& leftSum!= 0 && rightSum!=0*/)
                    {
                        Console.WriteLine($"{i}");
                        isEqual = true;
                        break;
                    }
                    else
                    {
                        isEqual = false;
                    }
                    leftSum = 0;
                    rightSum = 0;
                }
                if (isEqual == false)
                {
                    Console.WriteLine("no");
                } 
            }
            
        }
    }
}
