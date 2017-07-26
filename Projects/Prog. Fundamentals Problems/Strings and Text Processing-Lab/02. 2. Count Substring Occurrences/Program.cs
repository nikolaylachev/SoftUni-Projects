using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._2.Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            text = text.ToLower();
            string word = Console.ReadLine();
            word = word.ToLower();
            var lastIndex = -1;
            int counter = 0;
            while (true)
            {
                //var index = text.IndexOf(word,lastIndex+1);
                lastIndex = text.IndexOf(word, lastIndex + 1);
                if(lastIndex != -1)//if (index != -1)
                {
                    counter++;
                    //lastIndex = index;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
