using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku_solver_Fisrt_try_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = {
                       { 1,2,3},
                       { 4,5,6},
                       { 7,0,0},
            };
            int row = 0, col = 0,counter=0;
            int sum = 28;// sum=0!!!!!!!!!!!!!!!
            /*for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    sum += matrix[row, col];
                }
            }
            Console.WriteLine("{0}", sum);*/
            if (sum < 45)
            {
                for ( row = 0; row < 3; row++)
                {
                    for ( col = 0; col < 3; col++)
                    {
                        if (matrix[row,col] == 0)
                        {
                            for (int i = 1; i <= 9; i++)
                            {
                                matrix[row, col] = i;
                                if ((matrix[row,col]+sum) < 45 )
                                {
                                    matrix[row, col] = i;
                                    counter++;
                                }
                                
                                if ((matrix[row, col] + sum) == 45)
                                {
                                    sum += matrix[row, col];
                                    break;
                                }
                            }
                            //sum += matrix[row, col];
                        }
                        //sum += matrix[row, col];
                    }
                    
                }
            }

           if (sum == 45)
            {
                for ( row = 0; row < 3; row++)
                {
                    for ( col = 0; col < 3; col++)
                    {
                        Console.Write("{0} ",matrix[row, col]);
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine(sum);
            
        }
    }
}
