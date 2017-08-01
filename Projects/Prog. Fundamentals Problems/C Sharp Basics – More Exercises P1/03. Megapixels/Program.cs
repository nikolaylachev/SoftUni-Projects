using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double resolution = (width * height) / 1000000D;
            Console.WriteLine($"{width}x{height} => {Math.Round(resolution,1)}MP");
        }
    }
}
