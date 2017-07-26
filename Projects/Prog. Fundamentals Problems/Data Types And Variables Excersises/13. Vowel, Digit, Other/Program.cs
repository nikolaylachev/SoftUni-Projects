using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Vowel__Digit__Other
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            if (ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u' || ch=='y')
            {
                Console.WriteLine("vowel");
            }
            else if (ch >='0' && ch<='9')
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
