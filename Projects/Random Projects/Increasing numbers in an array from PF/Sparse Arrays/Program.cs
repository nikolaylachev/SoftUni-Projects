using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparse_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string[] str = new string [size] ;
            for (int i = 0; i < size; i++)
            {
                str[i] = Console.ReadLine();
            }

            int numberOfQueries = int.Parse(Console.ReadLine());
            string[] queries = new string[numberOfQueries];
            for (int i = 0; i < numberOfQueries; i++)
            {
                queries[i] = Console.ReadLine();
            }

            int counter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < numberOfQueries; j++)
                {
                    if (str[i].Contains(queries[j]))
                    {
                        counter++;
                    }
                    
                }
                Console.WriteLine(counter);
                counter = 0;

            }
        }
    }
}
