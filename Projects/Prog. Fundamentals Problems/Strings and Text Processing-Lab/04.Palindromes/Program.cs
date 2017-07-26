using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Program
    {
        static string GetPalindromes(string str)
        {
            string firstHalf = "";
            string secondReversedHalf = "";

            bool isPalindrome = false; 
                
                    if (str.Length % 2 == 0)
                    {
                        for (int i = 0; i < str.Length / 2; i++)
                        {
                            firstHalf += str[i];
                        }
                        for (int i = str.Length-1; i >= str.Length/2; i--)
                        {
                            secondReversedHalf += str[i];
                        }

                        isPalindrome = firstHalf == secondReversedHalf;

                        if (isPalindrome == true)
                        {
                            return str;
                        }
                    }

                    else if (str.Length % 2 != 0)
                    {
                        for (int i = 0; i < str.Length/2; i++)
                        {
                            firstHalf += str[i];
                        }
                        for (int i = str.Length-1; i > str.Length/2 ; i--)
                        {
                            secondReversedHalf += str[i];
                        }

                        isPalindrome = firstHalf == secondReversedHalf;

                        if (isPalindrome == true)
                        {
                           return str;
                        }
                    }
                
            return "";
        }

        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ',',','.','?','!').Where(w => w != "").ToArray();
            List<string> palindromes = new List<string>();

            foreach (var t in text)
            {
                palindromes.Add(GetPalindromes(t));
            }

            var palindromesWithoutBlanks = palindromes.Where(x => x != "").OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(", ",palindromesWithoutBlanks));

        }
    }
}
