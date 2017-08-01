using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPhoto = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double sizeOfPhoto = double.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: DSC_{numberOfPhoto:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:D2}/{month:D2}/{year:D4} {hours:D2}:{minutes:D2}");
            if (sizeOfPhoto < 1000)
            {
                Console.WriteLine($"Size: {sizeOfPhoto}B");
            }
            if (sizeOfPhoto >= 1000 && sizeOfPhoto < 1000000)
            {
                Console.WriteLine($"Size: {(sizeOfPhoto/1000)}KB");
            }
            if (sizeOfPhoto >= 1000000)
            {
                Console.WriteLine($"Size: {(sizeOfPhoto/1000000)}MB");
            }
            if (width > height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (landscape)");
            }
            if (width < height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (portrait)");
            }
            if (width == height)
            {
                Console.WriteLine($"Resolution: {width}x{height} (square)");
            }
        }
    }
}
