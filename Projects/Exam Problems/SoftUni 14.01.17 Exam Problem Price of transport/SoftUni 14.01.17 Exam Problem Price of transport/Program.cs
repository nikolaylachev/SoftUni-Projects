using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17_Exam_Problem_Price_of_transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOFDay = Console.ReadLine();
            double price;
            if (distance<20)
            {
                
                if (timeOFDay=="day")
                {
                    price = 0.7 + (distance * 0.79);
                    Console.WriteLine(price);
                }
                else if (timeOFDay=="night")
                {
                    price = 0.7 + (distance*0.9);
                    Console.WriteLine(price);
                }
                 
            }
            else if (distance>=20 && distance<100)
            {
                if (timeOFDay=="day")
                {
                    price = distance * 0.09;
                    Console.WriteLine(price);
                }
                else if (timeOFDay=="night")
                {
                    price = distance * 0.09;
                    Console.WriteLine(price);
                }
            }
            else if (distance>=100)
            {
                if (timeOFDay=="day")
                {
                    price =  distance * 0.06;
                    Console.WriteLine(price);
                }
                else if (timeOFDay=="night")
                {
                    price = distance * 0.06;
                    Console.WriteLine(price);
                }
            }
            
        }
    }
}
