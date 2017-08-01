using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(long.MaxValue > Math.Pow(2,31));
            List<string> drivers = Console.ReadLine().Split(' ').ToList();

            List<double> zones = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List <double> checkpoints = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            List<double> startingFuelOfEveryDriver = new List<double>();
            for (int i = 0; i < drivers.Count; i++)
            {
                startingFuelOfEveryDriver.Add ((long)drivers[i][0]);
            }

            long checkpointsCounter = 0L;

            for (int driversIndex = 0; driversIndex < drivers.Count; driversIndex++)
            {
                for (int zonesIndex = 0; zonesIndex < zones.Count; zonesIndex++)
                {
                    for (int checkpointsIndex = 0; checkpointsIndex < checkpoints.Count; checkpointsIndex++)
                    {

                        if (zonesIndex == checkpoints[checkpointsIndex])
                        {
                            checkpointsCounter++;
                        }
                        else if(zonesIndex != checkpoints[checkpointsIndex])
                        {
                            checkpointsCounter += 0;
                            
                        }
                    }//End of third for loop.

                    if (checkpointsCounter > 0)
                    {
                        startingFuelOfEveryDriver[driversIndex] += zones[zonesIndex];
                        checkpointsCounter = 0;
                        if (startingFuelOfEveryDriver[driversIndex] <= 0)
                        {
                            Console.WriteLine($"{drivers[driversIndex]} - reached {zonesIndex}");
                            break;
                        }
                    }
                    else if (checkpointsCounter == 0)
                    {
                        startingFuelOfEveryDriver[driversIndex] -= zones[zonesIndex];
                        checkpointsCounter = 0;
                        if (startingFuelOfEveryDriver[driversIndex] <= 0)
                        {
                            Console.WriteLine($"{drivers[driversIndex]} - reached {zonesIndex}");
                            break;
                        }
                    }

                    if (zonesIndex == zones.Count - 1 && startingFuelOfEveryDriver[driversIndex] > 0)
                    {
                        Console.WriteLine($"{drivers[driversIndex]} - fuel left {startingFuelOfEveryDriver[driversIndex]:f2}");
                        break;
                    }
                }//End of second for loop. 

            }//End of third for loop.
        }
    }
}
