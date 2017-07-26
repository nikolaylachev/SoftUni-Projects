using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadAllText("sample_text.txt");

            var newText = text.Where(x => x == ',' || x == '.' || x == '!' || x == '?' || x == ':');
            Console.WriteLine(string.Join(", ",newText));

            //File.WriteAllText("newSampleText",newText);- It gives error but it is not needed anyway.
        }
    }
}
