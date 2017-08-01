using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //Top
            Console.WriteLine(new string('%',2*n));
            if (n%2==0)
            {
                for (int i = 1; i <= n-1; i++)
                {
                    if (i==n/2)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ',n-2));
                        Console.Write(new string('*',2));
                        Console.Write(new string(' ',n-2));
                        Console.WriteLine("%");
                    }
                    else
	                {
                        Console.Write("%");
                        Console.Write(new string(' ', (2 * n) - 2));
                        Console.WriteLine("%");
                    }
                }
            }
            else if (n%2==1)
            {
                for (int i = 1; i <=n ; i++)
                {
                    if (i == (n / 2) + 1)
                    {
                        Console.Write("%");
                        Console.Write(new string(' ',n-2));
                        Console.Write(new string('*',2));
                        Console.Write(new string(' ',n-2));
                        Console.WriteLine("%");
                    }
                    else
                    {
                        Console.Write("%");
                        Console.Write(new string(' ', (2 * n) - 2));
                        Console.WriteLine("%");
                    }
                }
            }

            //Bottom
            Console.WriteLine(new string('%',2*n));
        }
    }
}
