using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static string reverseString(string str)
        {
            string reverse = string.Empty;
            for (int i = str.Length-1; i >= 0; i--)
            {
                reverse += str[i];
            }
            return reverse;
        }
        static void Main(string[] args)
        {
            List<string> bites = Console.ReadLine().Split(' ').ToList();
            bites.RemoveAll(x => x.Length != 2);
            for (int i = 0; i < bites.Count; i++)
            {
                bites[i] = reverseString(bites[i]);
            }
            bites.Reverse();
            List<int> listOfDecimals = new List<int>(bites.Count);
            foreach (var item in bites)
            {
                Console.Write((char)(int.Parse(item,System.Globalization.NumberStyles.HexNumber)));
            }

            //string bites = "F6";
            //Console.WriteLine(string.Join(", ",bites));
            //Console.WriteLine(string.Join(", ",listOfDecimals));
            //Console.WriteLine((char)100);//d
            Console.WriteLine();
        }
    }
}
