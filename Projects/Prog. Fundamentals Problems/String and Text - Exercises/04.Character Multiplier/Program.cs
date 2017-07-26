using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Character_Multiplier
{
    class Program
    {
        static long GetSumOfCharacters(string s1 , string s2)
        {
            long sum = 0L;
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    sum += (long)s1[i] * (long)s2[i];
                }
            }
            else if (s1.Length != s2.Length)
            {
                if (s1.Length > s2.Length)
                {
                    for (int i = 0; i < s2.Length; i++)
                    {
                        sum += (long)s1[i] * (long)s2[i];
                    }
                    for (int i = s2.Length; i < s1.Length; i++)
                    {
                        sum += (long)s1[i];
                    }
                }
                else if (s1.Length < s2.Length)
                {
                    for (int i = 0; i < s1.Length; i++)
                    {
                        sum += (long)s1[i] * (long)s2[i];
                    }
                    for (int i = s1.Length ; i < s2.Length; i++)
                    {
                        sum += (long)s2[i];
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            Console.WriteLine(GetSumOfCharacters(input[0],input[1]));
        }
    }
}
