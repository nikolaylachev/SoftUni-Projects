using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF___Lecure_22._05._17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zdrasti");
            var name = Console.ReadLine();
            Console.WriteLine($"Zdrasti, {name}!");

            dynamic a = 5;
            Console.WriteLine(a);
            a = "hello";
            Console.WriteLine(a);
            // Стигнах до 48:49: https://softuni.bg/trainings/resources/video/14879/video-screen-22-may-2017-svetlin-nakov-programming-fundamentals-may-2017 
            string name2 = Console.ReadLine();
            Console.WriteLine($"Hello, {name2}!");

        }
    }
}
