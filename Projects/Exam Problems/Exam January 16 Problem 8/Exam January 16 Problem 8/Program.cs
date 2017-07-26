using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int maxSequenceOfNumbers = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    counter++;
                    if (counter > maxSequenceOfNumbers)
                    {
                        maxSequenceOfNumbers = counter;
                    }
                }
                else if (numbers[i] > numbers[i + 1])
                {
                    if (counter > maxSequenceOfNumbers)
                    {
                        maxSequenceOfNumbers = counter;
                    }
                    counter = 0;
                }
            }
            Console.WriteLine(maxSequenceOfNumbers + 1);
        }

    }
}
