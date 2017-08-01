using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_9
{
    class Program
    { /*int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                Console.Write(new string(' ',n-row));
                for (int i = 1; i <= row; i++)
                {
                   
                    Console.Write("*");
                    Console.Write(" ");
                   
                }
                Console.WriteLine();
            }*/
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfSpaces = n - 2;
            int numberOfDashes = 1;
            //Top
            Console.Write(new string(' ',n-1));
            Console.WriteLine(new string('*',1));
            //Middle Top
            for (int row = 2; row <=n ; row++)
            {
                Console.Write(new string(' ',n-row));
                for (int i = 1; i <=row; i++)
                {

                    if (i < row)
                    {
                        Console.Write("*");
                        Console.Write("-"); 
                    }
                    else if (i==row)
                    {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            //Middle Bottom
            for (int row = n-1; row >= 1; row--)
            {
                Console.Write(new string(' ',n-row));
                for (int col = 1; col <= row; col++)
                {
                    if (col < row)
                    {
                        Console.Write("*");
                        Console.Write("-"); 
                    }
                    else if (col == row)
                   {
                        Console.Write("*");
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
