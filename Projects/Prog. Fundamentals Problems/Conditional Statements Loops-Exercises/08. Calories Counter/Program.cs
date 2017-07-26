using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Cheese – 500 calories
             	Tomato sauce – 150 calories
             	Salami – 600 calories
	            Pepper – 50 calories 
             */
            int n = int.Parse(Console.ReadLine());
            string ingredients;
            int totalCalories = 0;
            for (int i = 1; i <= n; i++)
            {
                ingredients = Console.ReadLine();
                ingredients=ingredients.ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
