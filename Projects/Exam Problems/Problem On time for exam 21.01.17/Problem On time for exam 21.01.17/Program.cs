using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_On_time_for_exam_21._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());
            if ((hourOfArrival > hourOfExam) || (hourOfArrival == hourOfExam && minuteOfArrival > minuteOfExam))//Late condition
            {
                Console.WriteLine("Late");
                //
                
            }
            else if ((hourOfArrival==hourOfExam && minuteOfArrival == minuteOfExam) || (hourOfArrival==(hourOfExam-1) && minuteOfExam<=(minuteOfArrival-30)))//On time condition
            {
                Console.WriteLine("On time");
            }
            else if ((hourOfArrival < hourOfExam) || (hourOfArrival<=(hourOfExam-1) && minuteOfExam > (minuteOfArrival-30)) )//Early condition
            {
                Console.WriteLine("Early");
            

            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());
            DateTime timeOfExam = new DateTime(1,1,1,hourOfExam,minuteOfExam,0);
            DateTime timeOfArrival = new DateTime(1, 1, 1, hourOfArrival, minuteOfArrival, 0);
            Console.WriteLine(timeOfArrival.ToShortTimeString());
            if (timeOfExam > timeOfArrival)
            {
                Console.WriteLine("Early");
            }
            if (timeOfExam < timeOfArrival)
            {
                Console.WriteLine("Late");
                Console.Write("{0}:",Math.Abs(timeOfArrival.Hour-timeOfExam.Hour));
                Console.WriteLine("{0}",Math.Abs(timeOfArrival.Minute-timeOfExam.Minute));
            }
            if (timeOfExam == timeOfArrival)
            {
                Console.WriteLine("On time");
            }
            int hourOfExam = int.Parse(Console.ReadLine());
            int minuteOfExam = int.Parse(Console.ReadLine());
            int hourOfArrival = int.Parse(Console.ReadLine());
            int minuteOfArrival = int.Parse(Console.ReadLine());

            int hoursDifference = (hourOfExam-hourOfArrival);
            int minutesDifference = (minuteOfExam - minuteOfArrival);
            Console.WriteLine("{0:00}:{1:00}",hoursDifference,minutesDifference);
            if ((hoursDifference==0 && minutesDifference==0) || (hoursDifference<=1 && minutesDifference<=60))
            {
                Console.WriteLine("On time");
            }
            //if ()
            {

            }*/
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int studentHours = int.Parse(Console.ReadLine());
            int studentMinutes = int.Parse(Console.ReadLine());

            int examTime = examHours * 60 + examMinutes;
            int studentTime = studentHours * 60 + studentMinutes;
            int minutesDifference = studentTime - examTime;

            if (minutesDifference < -30)
                Console.WriteLine("Early");
            else if (minutesDifference <= 0)
                Console.WriteLine("On time");
            else
                Console.WriteLine("Late");

            if (minutesDifference != 0)
            {
                int hours = Math.Abs(minutesDifference / 60);
                int minutes = Math.Abs(minutesDifference % 60);
                if (hours > 0)
                {
                    if (minutes < 10)
                        Console.Write(hours + ":0" + minutes + " hours");
                    else
                        Console.Write(hours + ":" + minutes + " hours");
                }
                else
                    Console.Write(minutes + " minutes");
                if (minutesDifference < 0)
                    Console.WriteLine(" before the start");
                else
                    Console.WriteLine(" after the start");

            }

        }
    }
}
