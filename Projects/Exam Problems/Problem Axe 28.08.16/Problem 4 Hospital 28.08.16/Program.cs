using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_Hospital_28._08._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int[] numberOfPatients = new int[numberOfDays];

            int numberOfDoctors = 7;//Given
            int numberOfThreadedPatients = 0;
            int numberOfUntreadedPatients = 0;
            int sumOfTreadedPatients = 0, sumOfUntreadedPatients=0;
            //Entering the patiens
            for (int i = 0; i < numberOfDays; i++)
            {
                numberOfPatients[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfDays; i++)
            {
                if (i % 3 == 2)//Finding the day before the day which is equally divided by 3.
                {
                    if (sumOfUntreadedPatients > sumOfTreadedPatients)
                    {
                        numberOfDoctors++;
                    }
                }

                if (numberOfPatients[i] <= numberOfDoctors)
                {
                    numberOfThreadedPatients = numberOfPatients[i];
                    numberOfUntreadedPatients = 0;

                    sumOfTreadedPatients += numberOfThreadedPatients;
                    sumOfUntreadedPatients += numberOfUntreadedPatients;
                }
                else if (numberOfPatients[i] > numberOfDoctors)
                {
                    numberOfThreadedPatients = numberOfDoctors;
                    numberOfUntreadedPatients = numberOfPatients[i] - numberOfDoctors;
                    sumOfTreadedPatients += numberOfThreadedPatients;
                    sumOfUntreadedPatients += numberOfUntreadedPatients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", sumOfTreadedPatients);
            Console.WriteLine("Untreated patients: {0}.",sumOfUntreadedPatients);
        }
    }
}
