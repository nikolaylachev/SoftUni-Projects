using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             •	Група до 5 човека – лек автомобил;
•	Група от 6 до 12 – микробус;
•	Група от 13 до 25 – малък автобус;
•	Група от 26 до 40 – голям автобус;
•	Група от 41 или повече – влак.
*/
            int numberOfGroups = int.Parse(Console.ReadLine());
            int[] groups = new int[numberOfGroups];
            double car = 0, microbus = 0, smallBus = 0, bigBus = 0, train = 0, sum = 0;

            for (int i = 0; i < numberOfGroups; i++)
            {
                groups[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numberOfGroups; i++)
            {
                if (groups[i]>=1 && groups[i]<=5)
                {
                    car += groups[i];
                }
                if (groups[i]>=6 && groups[i]<=12)
                {
                    microbus += groups[i];
                }
                if (groups[i]>=13 && groups[i]<=25)
                {
                    smallBus += groups[i];
                }
                if (groups[i]>=26 && groups[i]<=40)
                {
                    bigBus += groups[i];
                }
                if (groups[i]>=41)
                {
                    train += groups[i];
                }
                sum += groups[i];
            }
            double carInPercent = 0.0;
            carInPercent = (car / sum) * 100;
            double microBusInPercent = 0.0;
            microBusInPercent = (microbus / sum) * 100;
            double smallBusInPercent = 0.0;
            smallBusInPercent = (smallBus / sum) * 100;
            double bigBusInPercent = 0.0;
            bigBusInPercent=(bigBus / sum) * 100;
            double trainInPercent = 0.0;
            trainInPercent=(train / sum) * 100;
            Console.WriteLine("{0:f2}%",Math.Round(carInPercent,2));
            Console.WriteLine("{0:f2}%", Math.Round(microBusInPercent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(smallBusInPercent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(bigBusInPercent, 2));
            Console.WriteLine("{0:f2}%", Math.Round(trainInPercent, 2));

        }
    }
}
