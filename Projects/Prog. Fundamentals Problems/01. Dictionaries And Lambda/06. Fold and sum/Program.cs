using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = numbers.Length / 4;
            int[] firstRow = numbers.Take(k).Reverse().ToArray();
            int[] lastRow = numbers.Reverse().Take(k).ToArray();
            int[] firstLastRow = firstRow.Concat(lastRow).ToArray();
            int[] centerRow = numbers.Skip(k).Take(2 * k).ToArray();
            for (int i = 0; i < firstLastRow.Length; i++)
            {
                centerRow[i] += firstLastRow[i];
            }
            Console.WriteLine(string.Join(" ",centerRow));
        }
    }
}
