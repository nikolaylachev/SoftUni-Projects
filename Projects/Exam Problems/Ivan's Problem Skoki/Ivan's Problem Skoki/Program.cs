using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan_s_Problem_Skoki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int [size];
   

            for (int i = 0; i < numbers.Length; i++)//Enterting the elements of the array
            {
                Console.Write("arr[{0}]= ",i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int result = numbers[0];//Result's value equals the first element of the array

            for (int i = 1; i < numbers.Length; i++)//The starts at the second element of the array
            {
                if (numbers[i] % 2 == 0)
                {
                    result += numbers[i];
                    result %= 1024;
                    i++; //Skip over one element(Makes the step = 2)
                }
                else if (numbers[i] % 2 == 1)
                {
                    result *= numbers[i];
                    result %= 1024;
                }
            }
            Console.WriteLine(result);
        }
    }
}
