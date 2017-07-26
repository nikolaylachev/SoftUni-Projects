using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_and_Lists___Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ////List<string> dates = Console.ReadLine().Split(' ').ToList();
            ////var result = dates.OrderBy(date => date);
            ////Console.WriteLine(string.Join(", ",result));
            //List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            //numbers.RemoveAll(p => p % 2 == 1);
            //var result1 = (numbers.FindAll(x => x <= numbers.Average()));
            //var result2 = (numbers.FindAll(x => x > numbers.Average()));
            ////Console.WriteLine(string.Join(", ",numbers));
            //for (int i = 0; i < result1.Count; i++)
            //{
            //    result1[i] -= 1;
            //}

            //for (int i = 0; i < result2.Count; i++)
            //{
            //    result2[i] += 1;
            //}
            //if( (numbers.FindIndex(x => x > numbers.Average())) < (numbers.FindIndex(x => x <= numbers.Average())) && result2.Count > 0)
            //{
            //    Console.Write(string.Join(" ", result2));
            //    Console.Write(" ");
            //    Console.WriteLine(string.Join(" ", result1));
            //}
            //else if ((numbers.FindIndex(x => x > numbers.Average())) < (numbers.FindIndex(x => x <= numbers.Average())) && result2.Count == 0)
            //{
            //    Console.WriteLine(string.Join(" ", result1));
            //}
            //if( (numbers.FindIndex(x => x > numbers.Average())) > (numbers.FindIndex(x => x <= numbers.Average())) && result1.Count > 0)
            //{
            //    Console.Write(string.Join(" ", result1));
            //    Console.Write(" ");
            //    Console.WriteLine(string.Join(" ", result2));
            //}
            //else if ((numbers.FindIndex(x => x > numbers.Average())) > (numbers.FindIndex(x => x <= numbers.Average())) && result1.Count == 0)
            //{
            //    Console.WriteLine(string.Join(" ",result2));
            //}
            //var variable = 1.5 * 1L;
            List<int> list = new List<int>()
            { 1, 1, 2, 3, 4, 5, 1 };
            var result = list.FindAll(x => x == 1).ToList();
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
