using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_some_stuff
{
    class Program
    {
        static void Swap(string x,string y)
        {
            string swap=x;
            x = y;
            y = swap;
            Console.WriteLine("{0} {1}", x,y);
        }
        static void reverseString(string s1)
        {
            string reverse = "";
            for (int i = s1.Length-1; i >=0; i--)
            {
                reverse += s1[i];
            }
            Console.WriteLine(reverse);
        }
        static void Main(string[] args)
        {
            int a = 4;// 4(10) = 0100(2)
            Console.WriteLine(a<<1);// 8(10) = 1000(2)
            Console.WriteLine((a==4 ? "Yes":"No"));
            Console.WriteLine(++a);
            string s1 = Console.ReadLine();
            reverseString(s1);
            double counter = 0.0D;
            
           
        }
    }
}
