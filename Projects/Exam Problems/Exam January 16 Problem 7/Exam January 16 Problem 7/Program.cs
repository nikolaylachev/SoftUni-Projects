using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int [size];
            int firstSum = 0, secondSum = 0, thirdSum = 0;
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < size; i+=3)
            {
                firstSum += arr[i];
            }
            for (int i = 1; i < size; i+=3)
            {
                secondSum += arr[i];
            }
            for (int i = 2; i < size; i+=3)
            {
                thirdSum += arr[i];
            }
            Console.WriteLine("sum1 = {0}",firstSum);
            Console.WriteLine("sum2 = {0}", secondSum);
            Console.WriteLine("sum3 = {0}", thirdSum);

        }
    }
}
