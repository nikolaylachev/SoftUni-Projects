using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniada_Problem_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("D's x is: ");
            int dX = int.Parse(Console.ReadLine());
            Console.Write("D's y is: ");
            int dY = int.Parse(Console.ReadLine());
            Console.Write("B's x is: ");
            int bX = int.Parse(Console.ReadLine());
            Console.Write("B's y is: ");
            int bY = int.Parse(Console.ReadLine());
            int aX = dX;
            int aY = bY;
            int cX = bX;
            int cY = dY;
            Console.WriteLine("The other points of the rectangle are: ");
            Console.WriteLine("A("+aX+";"+aY+").");
            Console.WriteLine("C("+cX+";"+cY+").");
            Console.WriteLine("The ones you entered are: ");
            Console.WriteLine("B("+bX+";"+bY+").");
            Console.WriteLine("D("+dX+";"+dY+").");
        }
    }
}
