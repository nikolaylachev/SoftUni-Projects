using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace _05.Only_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string pattern = @"\d+";
            List<char> charactersAfterDigits = new List<char>();

            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length -1 && i+1 < text.Length )
                {
                    if ((text[i] >= '0' && text[i] <= '9') &&
                        ((text[i + 1] >= 'a' && text[i + 1] <= 'z') || (text[i + 1] >= 'A' && text[i + 1] <= 'Z')) )
                    {
                        charactersAfterDigits.Add(text[i + 1]);
                    } 
                }
            }

            MatchCollection numbersInString = Regex.Matches(text, pattern);

            for (int i = 0; i < charactersAfterDigits.Count; i++)
            {
                text = text.Insert(text.IndexOf(numbersInString[i].ToString()), charactersAfterDigits[i].ToString());
                text = text.Remove(text.IndexOf(numbersInString[i].ToString()), numbersInString[i].Length);
            }

            //foreach  (Match item in numbersInString)
            //{
            //    Console.WriteLine(item);
            //}

            Console.WriteLine(text);
        }
    }
}
