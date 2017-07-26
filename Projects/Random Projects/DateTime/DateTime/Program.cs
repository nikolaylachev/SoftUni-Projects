using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DateTime1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstHour = 9;
            int firstMinutes = 50;
            int secondHour = 23;
            int secondMinutes = 30;

           

            DateTime a = new DateTime(1, 1, 1, firstHour, firstMinutes, 0);
            

            Console.WriteLine(a);

            DateTime b = new DateTime(1, 1,1, secondHour, secondMinutes, 0);
            

            Console.WriteLine(b);

            TimeSpan span = b.Subtract(a);
            Console.WriteLine("Time Difference (seconds): " + span.Seconds);
            Console.WriteLine("Time Difference (minutes): " + span.Minutes);
            Console.WriteLine("Time Difference (hours): " + span.Hours);
            Console.WriteLine("Time Difference (days): " + span.Days);


            Console.WriteLine();



        }
        
    }
}
