using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telerik_Problem_Carpet
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //First row
            //Console.WriteLine("{0}{1}{2}{3}",new string('.',n/2-1), new string('/',1), new string('\\',1), new string('.',n/2-1));
            int numberOfDots = (n/2)-1;//12/2-2= 6-2=4;
            int numberOfOuterSpaces = 0;
            int numberOfInnerSpace;
            for (int i = 1; i <= n/2; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine("{0}{1}  {2}{3}", new string('.', numberOfDots), new string('/', i/2), new string('\\',i/2), new string('.',numberOfDots));
                    numberOfDots--; 
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{3}", new string('.',numberOfDots), new string('/',i-numberOfOuterSpaces), new string('\\',i-numberOfOuterSpaces), new string('.',numberOfDots));
                    numberOfOuterSpaces++;
                    numberOfDots--;
                }
            }
        }
    }
}
