using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17_Exam_Problem_Rekolta
{
    class Program
    {
        static void Main(string[] args)
        {
            int lozeInKm = int.Parse(Console.ReadLine());
            double grapesPerKm = double.Parse(Console.ReadLine());
            int neededLittersOfWine = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = lozeInKm * grapesPerKm;
            double totalWine = (0.4 * totalGrapes) / 2.5;

            
            //Console.WriteLine("{0} {1}",totalGrapes,totalWine);

            if (totalWine>neededLittersOfWine)
            {
                double remainingWine = Math.Ceiling(totalWine - neededLittersOfWine);
                double lettersPerWorker = Math.Ceiling(remainingWine / numberOfWorkers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.",Math.Floor(totalWine));
                Console.WriteLine("{0} liters left -> {1} liters per person.",remainingWine,lettersPerWorker);
            }
            else if (totalWine<neededLittersOfWine)
            {
                double remainingWine = neededLittersOfWine - totalWine; 
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.",Math.Floor(remainingWine));
            }
        }
    }
}
