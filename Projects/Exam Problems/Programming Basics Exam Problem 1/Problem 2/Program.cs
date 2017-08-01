using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int hoursNeeded = int.Parse(Console.ReadLine());
            int numberOfWorkers = int.Parse(Console.ReadLine());
            int numberOfWorkingDays = int.Parse(Console.ReadLine());

            int totalWorkingHours = numberOfWorkers * numberOfWorkingDays * 8;
            if (totalWorkingHours>=hoursNeeded)
            {
                Console.WriteLine("{0} hours left", Math.Abs(totalWorkingHours-hoursNeeded));
            }
            else if (totalWorkingHours < hoursNeeded)
            {
                Console.WriteLine("{0} overtime",Math.Abs(hoursNeeded-totalWorkingHours));
                Console.WriteLine("Penalties: {0}",Math.Abs((hoursNeeded-totalWorkingHours)*numberOfWorkingDays));
            }

        }
    }
}
