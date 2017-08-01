using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_21._01._17_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Complex conditional statements - Problem 13 - 21.01.17.
            int h = int.Parse(Console.ReadLine()); 
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            /*if ((y>h && y<=4*h)  && (x>=0 && x<h)||(x>2*h && x<= 3*h)) //For the rectangles next to the figure with coordinates 
            {                                                          //
                Console.WriteLine("Outside");
            }*/
            if ((x>0 && x<3*h) && (y>0 && y<h) || (x>h && x<2*h) && (y>=h && y<4*h))//Inside of the figure
            {
                Console.WriteLine("inside");
            }
            else if ((x<0 && x>3*h) && (y<0 && y>h) || (x<h && x>2*h) && (y<h || y>4*h)
                || (x<h && x>2*h) && (y>h && y<=4*h))//Outside of the figure
            {
                Console.WriteLine("outside");
            }
            else if (((x>=0 && x<=3*h) && y==0) || (x==h && (y>=h && y<=4*h)) || (x==2*h && (y>=h && y<=4*h)) || (x==0 && (y>=0 && y<=h)) 
                || ((x>=0 && x<=h) && y==h) || (x == 3*h && (y >= 0 && y <= h)) 
                || (x>=2*h && x<= 3*h) && y==h || ((x>=h && x<=2*h) && y==4*h))//Border
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
