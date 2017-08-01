using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            double BPM = double.Parse(Console.ReadLine());
            double numberOfBeats = double.Parse(Console.ReadLine());
            double numberOfBars = numberOfBeats / 4.00D;
           
            if (BPM > numberOfBeats)
            {

                Console.WriteLine($"{Math.Round(numberOfBars, 1)} bars - 0m {(int)((numberOfBeats*60)/BPM)}s");
            }
            else if (BPM < numberOfBeats)
            {
                int minutes = (int)((numberOfBeats * 60) / BPM);
                int seconds = minutes % 60;
                Console.WriteLine($"{Math.Round(numberOfBars, 1)} bars - {minutes/60}m {seconds}s");
            }
            else if (BPM == numberOfBeats)
            {
                Console.WriteLine($"{Math.Round(numberOfBars, 1)} bars - 1m 0s");
            }

           
        }
    }
}
