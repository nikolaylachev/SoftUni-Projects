using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maximumSum = int.Parse(Console.ReadLine());
            int sum = 0, counter = 0;
            int totalSum = 0;
            for (int first = n; first >= 1; first--)
            {
                for (int second = 1; second <= m; second++)
                {
                    counter++;
                    sum += 3 * (first * second);
                    totalSum += 3 * (first * second);
                    if (sum >= maximumSum)
                    {
                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maximumSum}");
                        break;
                    }
                    else if (sum < maximumSum)
                    {
                        //break;
                    }
                }
                if (sum >= maximumSum)
                {
                    break;
                }
            }//End of last for loop

            if (totalSum < maximumSum)
            {
                Console.WriteLine($"{counter} combinations");
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}
