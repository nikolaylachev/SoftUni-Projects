using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cake_ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient;
            int counter = 0;
            do
            {
                ingredient = Console.ReadLine();
                switch (ingredient)
                {
                    case "Flour":
                        { Console.WriteLine($"Adding ingredient {ingredient}."); counter++; }
                        break;
                    case "Bread":
                        { Console.WriteLine($"Adding ingredient {ingredient}."); counter++; }
                            break;
                    case "Sugar":
                        { Console.WriteLine($"Adding ingredient {ingredient}."); counter++; }
                            break;
                    case "Butter":
                        { Console.WriteLine($"Adding ingredient {ingredient}."); counter++; }
                            break;
                    case "Bake!":
                        {
                            break;
                        }
                        break;
                    default:
                        counter += 0;
                        break;
                }
                
            } while (ingredient != "Bake!" && counter <= 20);
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
