using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());  
            string numberToString = number.ToString();
            
            if (number==0)
            {
                Console.WriteLine("zero");
            }
            if (number == 1)
            {
                Console.WriteLine("one");
            }
            if (number == 2)
            {
                Console.WriteLine("two");
            }
            if (number == 3)
            {
                Console.WriteLine("three");
            }
            if (number == 4)
            {
                Console.WriteLine("four");
            }
            if (number == 5)
            {
                Console.WriteLine("five");
            }
            if (number == 6)
            {
                Console.WriteLine("six");
            }
            if (number == 7)
            {
                Console.WriteLine("seven");
            }
            if (number == 8)
            {
                Console.WriteLine("eight");
            }
            if (number == 9)
            {
                Console.WriteLine("nine");
            }

            if (number==10)
            {
                Console.WriteLine("ten");
            }
            if (number==11)
            {
                Console.WriteLine("eleven");
            }
             if (number==12)
            {
                Console.WriteLine("twelve");
            }
            if (number==13)
            {
                Console.WriteLine("thirteen");
            }
            if (number==14)
            {
                Console.WriteLine("fourteen");
            }
             if (number == 15)
            {
                Console.WriteLine("fifteen");
            }
             if (number == 16)
            {
                Console.WriteLine("sixteen");
            }
             if (number == 17)
            {
                Console.WriteLine("seventeen");
            }
             if (number == 18)
            {
                Console.WriteLine("eighteen");
            }
             if (number == 19)
            {
                Console.WriteLine("nineteen");
            }

            if (number==100)
            {
                Console.WriteLine("one hundred");
            }
            if (number == 20)
            {
                Console.WriteLine("twenty");
            }
            if (number == 30)
            {
                Console.WriteLine("thirty");
            }
            if (number == 40)
            {
                Console.WriteLine("fourty");
            }
            if (number == 50)
            {
                Console.WriteLine("fifty");
            }
            if (number == 60)
            {
                Console.WriteLine("sixty");
            }
            if (number == 70)
            {
                Console.WriteLine("seventy");
            }
            if (number == 80)
            {
                Console.WriteLine("eighty");
            }
            if (number == 90)
            {
                Console.WriteLine("ninety");
            }
            if (number<0 || number>100)
            {
                Console.WriteLine("invalid number");
            }

            if (number>=20 && number!=20 && number!=30 && number!=40 && number!=50 && number!=60 && number!=70 && number!=80 && number!= 90 && number<=99)
            {
                int desetici = number / 10;
                int edinici = number % 10;
                switch (desetici)
            {
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("fourty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
                default:
                    break;
            }

                switch (edinici)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
