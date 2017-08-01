using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Area_of_a_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            float width = float.Parse(Console.ReadLine());
            float heigth = float.Parse(Console.ReadLine());
            Console.WriteLine("{0:f2}",(width*heigth));
        }
    }
}
