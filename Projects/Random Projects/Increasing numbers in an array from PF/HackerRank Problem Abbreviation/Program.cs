using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Abbreviation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           // string s1 = "daBcd";
            //string s2 = "ABC";

            for (int i = 1; i <= n; i++)
            {
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                if (s1 == s2)
                {
                    Console.WriteLine("YES");
                }
                else if(s1 != s2)
                {
                    Console.WriteLine("NO");
                }
                s1 = s1.ToUpper();
                //s2 = s2.ToUpper(); Useless. s2 is always Upper()
                Console.WriteLine(s1);
                Console.WriteLine(s2);
                if (s1.Contains(s2))
                {
                    Console.WriteLine("YES");
                }
                else if (!s1.Contains(s2))
                {
                    Console.WriteLine("NO");
                }
                string s3 = "abc--de";//abcde
                Console.WriteLine(s3.Remove(3,2));
            }
        }
    }
}
