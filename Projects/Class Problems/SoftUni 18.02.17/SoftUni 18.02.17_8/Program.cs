using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 14
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    result=(row+col)-1;
                    if (result>n)
                    {
                       result=2*n-result;
                    }
                    Console.Write("{0} ",result);
                }
                Console.WriteLine();
            }
        }
    }
}
