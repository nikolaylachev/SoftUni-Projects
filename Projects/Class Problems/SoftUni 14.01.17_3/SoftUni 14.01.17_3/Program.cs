using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if (hours== 23 && (minutes + 15)>=60)
            {
                hours = 0;
                minutes += 15;
                minutes %= 60;
            }
            else if ((minutes + 15) >= 60 && hours<23 )
            {
                minutes += 15;
                minutes %= 60;
                hours++;
            }
            else if (minutes + 15 < 60)
            {
                minutes += 15;
            }
        //Final check if minutes are from 0 to 9 to add an extra 0 or just to print the minutes as they are
            if (minutes<10)
            {
                Console.WriteLine(hours+":0"+minutes);
            }
            else
            {
                Console.WriteLine(hours+":"+minutes);        
            }
            
        }
    }
}
