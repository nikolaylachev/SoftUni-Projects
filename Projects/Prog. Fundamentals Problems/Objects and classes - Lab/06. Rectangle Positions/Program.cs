using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Positions
{
    class Program
    {
        class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
            //
            public int Right
            {
                get
                {
                    return Left + Width;
                }
            }
            public int Bottom
            {
                get
                {
                    return Top + Width;
                }
            }
            
            public bool IsInside(Rectangle r1, Rectangle r2)
            {
                bool isInside = false;
                if (r1.Left >= r2.Left && r1.Top <= r2.Top && r1.Right <= r2.Right && r1.Bottom <= r2.Bottom)
                {
                    isInside = true;
                }
                return isInside;
            }
        }
        static void Main(string[] args)
        {
            List<int> coordinates = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> coordinates2 = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Rectangle r1 = new Rectangle() {Left = coordinates[0], Top = coordinates[1], Width = coordinates[2], Height = coordinates[3] };
            Rectangle r2 = new Rectangle() { Left = coordinates2[0], Top = coordinates2[1], Width = coordinates2[2], Height = coordinates2[3] };
            Rectangle r3 = new Rectangle();
            bool isInside = r1.IsInside(r1, r2);
            if (isInside == true)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
           // Console.WriteLine(isInside);
        }
    }
}
