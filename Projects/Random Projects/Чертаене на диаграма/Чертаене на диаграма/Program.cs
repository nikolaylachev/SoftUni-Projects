using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Чертаене_на_диаграма
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            for (int i = 0; i < size ; i++)
            {
                for (int j = 1; j <=numbers[i]; j++)
                { 
                    Console.WriteLine("{0}{1}",new string(' ',i),new string('*',3));
                }
                //Console.WriteLine();
            }
        }
    }
}
