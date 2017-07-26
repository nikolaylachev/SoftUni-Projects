using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;
using System.Text.RegularExpressions;
namespace Exam_Preparation_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //BigInteger intMax = 2147483647 * 2147483647;
            /*List<string> time = Console.ReadLine().Split(':').ToList();
            int numberOfSteps = int.Parse(Console.ReadLine());
            int timeForEachStepSeconds = int.Parse(Console.ReadLine());

            int hour = int.Parse(time[0]);
            int minutes = int.Parse(time[1]);
            int seconds = int.Parse(time[2]);
            long neededTimeSeconds = 0L;
            
            DateTime timeFromInput = new DateTime(1, 1, 1, hour, minutes, seconds);

           
                try
                {
                   neededTimeSeconds = (long)numberOfSteps * timeForEachStepSeconds;
                   var timeFromInputToString = timeFromInput.AddSeconds(neededTimeSeconds).ToString("h:m:s");
                   Console.WriteLine($"Time Arrival: {timeFromInputToString}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                } 

            //var date = DateTime.ParseExact(Console.ReadLine(), 
            //    "h:m:s", 
            //    CultureInfo.InvariantCulture);
            */


            /* var nums = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
             long seconds = nums[2] + 60 * nums[1] + 60 * 60 * nums[0];

             var secondsToAdd =
                 long.Parse(Console.ReadLine()) *
                 long.Parse(Console.ReadLine());
             seconds += secondsToAdd;//Total seconds that we need to transform to hh:mm:ss.

             //Transforming the total seconds

             var secs = seconds % 60;
             var mins = (seconds / 60) % 60;
             var hours = (seconds / 60 / 60) % 24;

             //Printing the result
             Console.WriteLine($"{hours:d2}:{mins:d2}:{secs:d2}");*/

            string command = "Console.ReadLine()";
            var substr1 = command.Substring(0, 7);
            var substr2 = command.Substring(8, command.Length-8);
            Console.WriteLine($"{substr1} . {substr2}");

            int a = 2000000000;
            int b = int.MaxValue;//long b = 2000000000
            long sum = a + (long)b;//sum = a + b;
            Console.WriteLine(sum);
        }
    }
}
