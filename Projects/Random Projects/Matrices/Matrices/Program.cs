using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size,size];
            int row, col;

            //Entering the array elements
            for ( row = 0; row < size; row++)
            {
                for (col = 0; col < size;col++)
                {
                    Console.Write("arr[{0}][{1}]= ",row,col);
                    matrix[row,col] = int.Parse(Console.ReadLine());
                }
            }

            //Print the array in a form of a matrix 
            for (row = 0; row < size; row++)
            {
                for (col = 0; col < size; col++)
                {
                    Console.Write("{0} ",matrix[row,col]);
                }
                Console.WriteLine();
            }

            int sum = matrix[0,0];
            int bestSum = sum;
            //Finding all the sums and the best sum.
            for (row = 0; row < size-1 ; row++)//size was -1
            {
                for (col = 0; col < size-1; col++)//size was -1 too
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    
                    if (sum>bestSum) //sum>bestSum
                    {
                        bestSum = sum;
                    }
                   
                }
                
            }
            Console.WriteLine("Best sum = {0}",bestSum);
        }
    }
}
