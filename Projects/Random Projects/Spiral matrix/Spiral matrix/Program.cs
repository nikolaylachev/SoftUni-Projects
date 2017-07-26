using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            double size = 25D;//n * n;
            double[,] matrix = {
                {1, 2, 3, 4, 5},
                {6, 7, 8, 9, 10},
                {11,12,13,14,15},
                {16,17,18,19,20},
                {21,22,23,24,25}
            };//new int [n,n];
            int ending = 0;
            int zero = 0;
            int copyRow = 0;
            int row = copyRow;//0
            int col = (int)Math.Sqrt(size) - 1;
            do
            {
                //copyRow = 0;
                row = copyRow;
                col = (int)Math.Sqrt(size) - 1;
                for (int i = row; i < Math.Sqrt(size); i++)//i < Math.Sqrt(size)+ending
                {
                    Console.Write("{0} ",matrix[row,i]);
                }

               for (int i = row+1; i < Math.Sqrt(size); i++)//row+1 i < Math.Sqrt(size)+ending
                {
                 Console.Write("{0} ",matrix[i,col]);
                }
            
               row = (int)Math.Sqrt(size)-1;
           
               for (int i = (int)Math.Sqrt(size)-2; i >= zero; i--)
               {
                 Console.Write("{0} ", matrix[row,i]);
               }

                col = zero;// row - row;
               for (int i = (int)Math.Sqrt(size)-2; i >= (zero)+1; i--)
               {
                 Console.Write("{0} ",matrix[i,col]);
               }
                size -= Math.Sqrt(size) + Math.Sqrt(size) - 1 + Math.Sqrt(size) - 1 + Math.Sqrt(size) - 2;
                copyRow++;
                zero++;
                //ending++;
            }
            while (size > 0);
            
        }
    }
}
