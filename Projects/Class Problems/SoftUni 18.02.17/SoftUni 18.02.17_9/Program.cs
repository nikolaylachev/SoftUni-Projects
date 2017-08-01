using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 13
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            int row = 0, col = 1;
            for (int i = 1; i <=n ; i++)
            {
                result += row;
                row++;
                Console.WriteLine(result);
            }

           

            //Problem 12-Fibonacci Sequence
            /*int n = int.Parse(Console.ReadLine());
            if (n==0)
            {
                Console.WriteLine(1);
            }

            else
            {
                int first = 0, second = 1;
                int result = 0;
                for (int i = 1; i <= n; i++)//0,1,1,2
                {
                    result = first + second;
                    first = second;
                    second = result;

                }
                Console.WriteLine(result); 
            }*/
        }
    }
}
