using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_January_16_Problem_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(1, month, day);
            //Console.WriteLine(date.ToShortDateString());
            Console.WriteLine("{0:d.MM}",date.AddDays(5));
        }
    }
}
