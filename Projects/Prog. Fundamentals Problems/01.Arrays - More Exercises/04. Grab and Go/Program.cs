using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1 3 5 7 12 2 3 5 12
             3

            */
            //int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long number = long.Parse(Console.ReadLine());
            int currentNumberPosition = 0;
            int bestNumberPosition = 0;
            bool isNumberFound = false;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == number)
                {
                    currentNumberPosition = i;
                    isNumberFound = true;
                }
               

                if (currentNumberPosition > bestNumberPosition)
                {
                    bestNumberPosition = currentNumberPosition;
                }
                //isNumberFound = false;
            }
            long sum = 0;
            
            if (isNumberFound == true)
            {
                for (int i = 0; i < bestNumberPosition; i++)
                {
                   sum += arr[i];
                }
                //Console.WriteLine(bestNumberPosition);
                Console.WriteLine(sum); 
            }
            else if (isNumberFound == false)
            {
                Console.WriteLine("No occurrences were found!");
            }

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(long.MaxValue);
        }
    }
}
