using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17_Exam_Problem_Pool_Pipes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int volumeOfPool = int.Parse(Console.ReadLine());
            int pipe1 = int.Parse(Console.ReadLine());
            int pipe2 = int.Parse(Console.ReadLine());
            double hoursOFAbsence = double.Parse(Console.ReadLine());
            double totalVolume = pipe1 * hoursOFAbsence + pipe2 * hoursOFAbsence;
                if (totalVolume < volumeOfPool)
                {
                    double pipe1InPercent = ((pipe1 * hoursOFAbsence) / totalVolume) * 100;
                    double pipe2InPercent = ((pipe2 * hoursOFAbsence) / totalVolume) * 100;
                    Console.Write("The pool is " + (int)((totalVolume / volumeOfPool) * 100) + "% full.");
                    Console.Write(" Pipe 1: {0}%.",(int)pipe1InPercent);
                    Console.WriteLine(" Pipe 2: {0}%.",(int)pipe2InPercent);
                }
                else if (totalVolume >= volumeOfPool)
                {
                    Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hoursOFAbsence, (totalVolume - volumeOfPool));
                }
            */

            int volumeOfPool = int.Parse(Console.ReadLine());
            int firstPipe = int.Parse(Console.ReadLine());
            int secondPipe = int.Parse(Console.ReadLine());
            double hoursOfAbsence = double.Parse(Console.ReadLine());

            double totalVolume = (firstPipe * hoursOfAbsence) + (secondPipe * hoursOfAbsence);
            double totalVolumeInPercent = (totalVolume / volumeOfPool) * 100;
            if (totalVolume <= volumeOfPool )
            {
                double firstPipeInPercent = ((firstPipe*hoursOfAbsence) / totalVolume) * 100;
                double secondPipeInPercent = ((secondPipe * hoursOfAbsence) / totalVolume) * 100;
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.",(int)totalVolumeInPercent,(int)firstPipeInPercent,(int)secondPipeInPercent);

            }
            else if (totalVolume > volumeOfPool)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.",hoursOfAbsence,totalVolume-volumeOfPool);
            }
        }
    }
}
