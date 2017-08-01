using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Kangaroo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');//0 2 5 3 -> NO
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            //int counter = 0;
            //if (x1 - x2) % (v2 - v1) == 0 then our kangaroos will meet each other : )
            if (x1 <  x2 &&  v1 > v2)
            {
                do
                {
                    x1 += v1;
                    x2 += v2;
                    //Console.WriteLine("Fisrt = {0}, Second = {1} ", x1, x2);
                    if (x1 > x2)
                    {
                        Console.WriteLine("NO");
                        break;
                    }
                    if (x1 == x2 )
                    {
                        Console.WriteLine("YES");
                        break;
                    }
                }
                while (x1 != x2);
               
              
                
            }
            else if(x1 < x2 && v1 <= v2)
            {
                Console.WriteLine("NO");
            }
        }
    }
}
