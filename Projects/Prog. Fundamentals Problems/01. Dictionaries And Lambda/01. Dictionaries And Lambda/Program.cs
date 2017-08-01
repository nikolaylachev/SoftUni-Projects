using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dictionaries_And_Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();//1 2 3
            var dict = new SortedDictionary<double, int>();
            foreach (var num in numbers)
            {
                if (dict.ContainsKey(num))//dict[1] is contained then
                {
                    dict[num]++;//dict[1].Value++;
                }
                else
                {
                    dict[num] = 1;//dict[1].Value = 1;
                }
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
