using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string servicePackage = Console.ReadLine();

            double priceOfHall = 0.00D;
            double discountOfPackage = 0.00D;
            double priceOfPackage = 0.00D;
            double totalPrice = 0.00D;
            double totalDiscount = 0.00D;
            double pricePerPerson = 0.00D;
            if (groupSize > 0 && groupSize <= 50)
            {
                Console.WriteLine("We can offer you the Small Hall");
                priceOfHall = 2500.00D;
                switch (servicePackage)
                {
                    case "Normal":
                        {
                            priceOfPackage = 500.00D;
                            discountOfPackage = 0.05D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    case "Gold":
                        {
                            priceOfPackage = 750.00D;
                            discountOfPackage = 0.1D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    case "Platinum":
                        {
                            priceOfPackage = 1000.00D;
                            discountOfPackage = 0.15D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    default:
                        break;
                }
            }
            else  if (groupSize > 50 && groupSize <= 100)
            {
                Console.WriteLine("We can offer you the Terrace");
                priceOfHall = 5000.00D;
                switch (servicePackage)
                {
                    case "Normal":
                        {
                            priceOfPackage = 500.00D;
                            discountOfPackage = 0.05D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    case "Gold":
                        {
                            priceOfPackage = 750.00D;
                            discountOfPackage = 0.1D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    case "Platinum":
                        {
                            priceOfPackage = 1000.00D;
                            discountOfPackage = 0.15D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    default:
                        break;
                }

            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                Console.WriteLine("We can offer you the Great Hall");
                priceOfHall = 7500.00D;
                switch (servicePackage)
                {
                    case "Normal":
                        {
                            priceOfPackage = 500.00D;
                            discountOfPackage = 0.05D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    case "Gold":
                        {
                            priceOfPackage = 750.00D;
                            discountOfPackage = 0.1D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    case "Platinum":
                        {
                            priceOfPackage = 1000.00D;
                            discountOfPackage = 0.15D;
                            totalPrice = priceOfHall + priceOfPackage;
                            totalDiscount = totalPrice - (discountOfPackage * totalPrice);
                            pricePerPerson = totalDiscount / groupSize;
                            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
                        }
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
        }
    }
}
