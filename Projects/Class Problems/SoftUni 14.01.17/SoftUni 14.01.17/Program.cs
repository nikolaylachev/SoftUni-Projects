using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int sum=first+second+third;
            int minutes = sum / 60, seconds = sum % 60;
            if (seconds<10)
            {
                Console.WriteLine(minutes+":0"+seconds);
            }
            else if(seconds>=10)
            {
                Console.WriteLine(minutes+":"+seconds);

            }
            */
            Console.Write("Enter minutes: ");
            double Minutes = double.Parse(Console.ReadLine());
            Console.WriteLine("With Math.Rount() Minutes = {0}",Math.Round(Minutes));
            Console.WriteLine("With Math.Truncate() Minutes = {0}", Math.Truncate(Minutes));
            Console.WriteLine("With Math.Ceiling() Minutes = {0}", Math.Ceiling(Minutes));
            Console.WriteLine("With Math.Floor() Minutes = {0}", Math.Floor(Minutes));


        }
    }
}
