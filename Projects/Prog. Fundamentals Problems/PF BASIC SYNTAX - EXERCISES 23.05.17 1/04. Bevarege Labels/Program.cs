using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Bevarege_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            double energy = int.Parse(Console.ReadLine());
            double sugar = int.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine("{0}kcal, {1}g sugars", volume*energy/100, volume*sugar/100);
        }
    }
}
