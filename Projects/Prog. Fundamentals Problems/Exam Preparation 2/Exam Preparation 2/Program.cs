using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var marathonDays = decimal.Parse(Console.ReadLine());
            var runnersCount = decimal.Parse(Console.ReadLine());
            var lapsCount = decimal.Parse(Console.ReadLine());
            var trackLength = decimal.Parse(Console.ReadLine());
            var trackCapacity = decimal.Parse(Console.ReadLine());
            var moneyPerKilometer = decimal.Parse(Console.ReadLine());

            var totalDistance = Math.Min(runnersCount, marathonDays * trackCapacity) * trackLength * lapsCount;
            var moneyRaised = totalDistance / 1000 * moneyPerKilometer;
            Console.WriteLine($"Money raised: {moneyRaised:f2}");

           
            //Console.WriteLine();
        }
    }
}