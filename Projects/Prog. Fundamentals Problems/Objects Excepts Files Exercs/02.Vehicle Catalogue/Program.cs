using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Program
    {
        class Car
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public long HorsePower { get; set; }
        }

        static void Main(string[] args)
        {
            List<string> command = new List<string>();
            List<Car> cars = new List<Car>();

            do
            {
                command = Console.ReadLine().Split(' ').ToList();
                if (command[0] != "End")
                {
                    cars.Add(new Car()
                    {
                        Type= command[0],
                        Model = command[1],
                        Color = command[2],
                        HorsePower = long.Parse(command[3]),
                    });
                }
            } while (command[0] != "End");

            string wantedCar = "";
            decimal sumOfCars = 0.00M;
            decimal sumOfTrucks = 0.00M;
            decimal countOfCars = 0.00M;
            decimal countOfTrucks = 0.00M;
            decimal averageCars = 0.00M;
            decimal averageTrucks = 0.00M;

            do
            {
                wantedCar = Console.ReadLine();

                if (wantedCar != "Close the Catalogue")
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].Model == wantedCar)
                        {
                            if (cars[i].Type =="Car" || cars[i].Type == "Truck")
                            {
                                Console.WriteLine($"Type: {cars[i].Type}"); 
                            }
                            else if (cars[i].Type == "car")
                            {
                                Console.WriteLine("Type: Car");
                            }
                            if (cars[i].Type == "truck")
                            {
                                Console.WriteLine("Type: Truck");
                            }
                            Console.WriteLine($"Model: {cars[i].Model}");
                            Console.WriteLine($"Color: {cars[i].Color}");
                            Console.WriteLine($"Horsepower: {cars[i].HorsePower}");
                        }

                        if (cars[i].Type == "car" || cars[i].Type == "Car")
                        {
                            countOfCars++;
                            sumOfCars += cars[i].HorsePower;
                            averageCars = sumOfCars / countOfCars;
                        }
                        else if(cars[i].Type =="truck" || cars[i].Type == "Truck")
                        {
                            countOfTrucks++;
                            sumOfTrucks += cars[i].HorsePower;
                            averageTrucks = sumOfTrucks / countOfTrucks;
                        }

                    } 
                }

            } while (wantedCar != "Close the Catalogue");

            try
            {
                
                Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cars have average horsepower of: 0,00.");
            }

            try
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}."); 
            }
           
            catch (DivideByZeroException)
            {
                Console.WriteLine("Trucks have average horsepower of: 0,00.");
            }
        }
    }
}
