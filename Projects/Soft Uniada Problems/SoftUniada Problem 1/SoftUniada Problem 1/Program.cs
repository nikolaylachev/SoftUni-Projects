using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniada_Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a>0 && b>0 && c>0)
            {
                if ((a+b+c)==13)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else if (a>0 && b<0 && c<0)
            {
                if ((a+(b*-1)+(c*-1))==13)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else if (b>0 && a<0 && c<0)
            {
                if (((a*-1)+b+(c*-1))==13)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else if (c>0 && a<0 && b<0)
            {
                if ((a*-1)+(b*-1)+c==13)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            else if(a<0 && b<0 && c<0)
            {
                if (((a*-1)+(b*-1)+(c*-1))==13)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
