using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_words
{
    class Program
    {
        static void getMinMax(List<string> words)
        {

        }
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int pos2 = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[pos2];
                words[pos2] = temp;
            }
            Console.WriteLine(string.Join("\r\n",words));
        }
    }
}
