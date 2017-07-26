using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfSharps = 1;
            int numberOfDots = (((12 * n) - 5) - numberOfSharps)/2;
            //Top
            for (int i = 1; i <= 2*n-1; i++)
            {
                Console.WriteLine("{0}{1}{2}", new string('.',numberOfDots), new string('#',numberOfSharps),new string ('.',numberOfDots));
                numberOfSharps += 6;
                numberOfDots -= 3;
            }

            numberOfSharps = (((12 * n) - 5));
            int numberOfLDots = 2;
            int numberOfRightDots = 3;

            for (int i = 1; i <= n-1; i++)
            {
                if (i==1)
                {
                    Console.WriteLine("{0}", new string ('#',numberOfSharps));
                    numberOfSharps -= 6;
                }

                if (i > 1)
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', numberOfLDots), new string('#', numberOfSharps), new string('.', numberOfRightDots));
                    numberOfLDots += 3;
                    numberOfRightDots += 3;
                    numberOfSharps -= 6;
                }
                
            }
            numberOfSharps = 6 * n + 1;
            numberOfLDots =(((12*n-5)- numberOfSharps)-1)/2;
            numberOfRightDots = ((12*n-5)-numberOfSharps)/2 ;
            
            for (int i = 1; i <= n; i++)
            {
                if (i<n)
                {
                    Console.WriteLine("|{0}{1}{2}", new string('.', numberOfLDots), new string('#', numberOfSharps), new string('.', numberOfRightDots)); 
                }
                else if (i==n)
                {
                    Console.WriteLine("@{0}{1}{2}", new string('.', numberOfLDots), new string('#', numberOfSharps), new string('.', numberOfRightDots));
                }
            }
        }
    }
}
