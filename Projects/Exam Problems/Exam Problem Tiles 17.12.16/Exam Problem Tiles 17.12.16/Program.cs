using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_Tiles_17._12._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfSquare = int.Parse(Console.ReadLine());
            double widthOfTile = double.Parse(Console.ReadLine());
            double lengthOfTile = double.Parse(Console.ReadLine());
            int widthOfBench = int.Parse(Console.ReadLine());
            int lengthOfBench = int.Parse(Console.ReadLine());
            int totalSize = (lengthOfSquare*lengthOfSquare)-(widthOfBench*lengthOfBench);
            double tilesNeeded = totalSize / (widthOfTile*lengthOfTile);
            double timeNeeded = tilesNeeded * 0.2;
            Console.WriteLine(tilesNeeded);
            Console.WriteLine(timeNeeded);
        }
    }
}
