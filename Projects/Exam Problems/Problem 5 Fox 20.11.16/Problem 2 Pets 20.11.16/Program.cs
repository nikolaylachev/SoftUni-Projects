using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2_Pets_20._11._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int leftFoodInKg = int.Parse(Console.ReadLine());
            double foodForDogInKg = double.Parse(Console.ReadLine());
            double foodForCatInKg = double.Parse(Console.ReadLine());
            double foodForTurtleInGrams = double.Parse(Console.ReadLine());

            double foodForTurtleInKg = foodForTurtleInGrams / 1000.00D;
            double foodNeeded = (foodForDogInKg * numberOfDays) + (foodForCatInKg*numberOfDays) + (foodForTurtleInKg*numberOfDays);
            if (leftFoodInKg >= foodNeeded)
            {
                double total = Math.Abs(foodNeeded - leftFoodInKg);
                Console.WriteLine("{0} kilos of food left.", Math.Floor(total));
            }
            else if (leftFoodInKg < foodNeeded)
            {
                double total = Math.Abs(leftFoodInKg - foodNeeded);
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(total));
            }
        }
    }
}
