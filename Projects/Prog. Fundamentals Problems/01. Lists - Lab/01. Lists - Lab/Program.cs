using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Lists___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> positiveNumbers = new List<int>();
            int positivesCounter = 0;
            for (int num = 0; num < numbers.Count; num++)
            {
                if (numbers[num] > 0)
                {
                    positiveNumbers.Add(numbers[num]);
                    positivesCounter++;
                }
                else
                {
                    positivesCounter += 0;
                }
            }
            if (positivesCounter > 0)
            {
                positiveNumbers.Reverse();
                Console.WriteLine(string.Join(" ", positiveNumbers)); 
            }
            else if (positivesCounter == 0)
            {
                Console.WriteLine("empty");
            }
        }
    }
}
