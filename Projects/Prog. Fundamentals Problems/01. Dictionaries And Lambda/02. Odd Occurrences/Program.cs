using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine().ToLower().Split(' ').ToList();//Getting the words sequneces
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var w in words)//Looping the words list
            {
                if (dict.ContainsKey(w))//Finding if the word is contained and increasing its value by 1.
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            List<string> result = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
