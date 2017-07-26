using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {


        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(' ').ToArray();
            int maximumLength = int.Parse(Console.ReadLine());
            string ingredientsArray = string.Empty;
            int counter = 0;
            for (int i = 0; i < stringArr.Length; i++)
            {
                if (stringArr[i].Length == maximumLength && counter < 10)
                {
                    Console.WriteLine($"Adding {stringArr[i]}.");
                    counter++;
                    ingredientsArray += stringArr[i] + ", ";
                }
            }
            Console.WriteLine($"Made pizza with total of {counter} ingredients.");
            StringBuilder sb = new StringBuilder(ingredientsArray);
            sb[ingredientsArray.Length - 2] = '.';
            ingredientsArray = sb.ToString();
            Console.WriteLine($"The ingredients are: {ingredientsArray}");
            //string s = "abc";
            
            //sb[1] = 'x';
            //string newS = sb.ToString();
        }
    }
}
