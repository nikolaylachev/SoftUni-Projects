using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05.Write_to_File
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = File.ReadAllText("sample_text.txt");
            //text = text.Replace(".","");
            //text = text.Replace(",", "");
            //text = text.Replace("!", "");
            //text = text.Replace("?", "");
            //text = text.Replace(":", "");
            //File.WriteAllText("newSampleText.txt", text);
            //Console.WriteLine(text);
            string listOfBeers =  "Amstel, Tuborg, Zagorka.";
            string[] beers = listOfBeers.Split(new char [] { ' ', ',', '.'},StringSplitOptions.RemoveEmptyEntries).ToArray();
            Console.WriteLine(string.Join(", ",beers));
        }
    }
}
