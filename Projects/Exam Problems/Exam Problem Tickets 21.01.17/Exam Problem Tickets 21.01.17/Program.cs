using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Problem_Tickets_21._01._17
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketType = Console.ReadLine();// VIP – 499.99 лева. Normal – 249.99 лева.
            int numberOfPeople = int.Parse(Console.ReadLine());
            double result;
            if (numberOfPeople>=1 && numberOfPeople<=4)
            {
                budget -= budget * 0.75;
                switch (ticketType)
                {
                    case "VIP":
                        budget -= numberOfPeople * 499.99;
                        if (budget>=0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.",Math.Round(budget,2));
                        }
                        else if (budget<0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.",Math.Round((budget*-1),2));
                        }
                        break;
                    case "Normal":
                        budget -= numberOfPeople * 249.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    default:
                        break;
                }

            }
            if (numberOfPeople >= 5 && numberOfPeople <= 9)
            {
                budget -= budget * 0.6;
                switch (ticketType)
                {
                    case "VIP":
                        budget -= numberOfPeople * 499.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    case "Normal":
                        budget -= numberOfPeople * 249.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    default:
                        break;
                }
            }
            if (numberOfPeople >= 10 && numberOfPeople <= 24)
            {
                budget -= budget * 0.5;
                switch (ticketType)
                {
                    case "VIP":
                        budget -= numberOfPeople * 499.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    case "Normal":
                        budget -= numberOfPeople * 249.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    default:
                        break;
                }

            }
            if (numberOfPeople >= 25 && numberOfPeople <= 49)
            {
                budget -= budget * 0.4;
                switch (ticketType)
                {
                    case "VIP":
                        budget -= numberOfPeople * 499.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    case "Normal":
                        budget -= numberOfPeople * 249.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    default:
                        break;
                }

            }
            else if(numberOfPeople>=50)
            {
                budget -= budget * 0.25;
                switch (ticketType)
                {
                    case "VIP":
                        budget -= numberOfPeople * 499.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    case "Normal":
                        budget -= numberOfPeople * 249.99;
                        if (budget >= 0)
                        {
                            Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(budget, 2));
                        }
                        else if (budget < 0)
                        {
                            Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round((budget * -1), 2));
                        }
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
