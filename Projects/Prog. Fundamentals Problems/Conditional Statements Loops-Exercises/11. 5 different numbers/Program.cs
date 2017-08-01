using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._5_different_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (((b-a) >= 5))
            {
                for (int first = a; first <= b; first++)
                {
                    for (int second = a; second <= b; second++)
                    {
                        for (int third = a; third <= b; third++)
                        {
                            for (int fourth = a; fourth <= b; fourth++)
                            {
                                for (int fifth = a; fifth <= b; fifth++)
                                {
                                    if ((first < second) && (second < third) && (third < fourth) && (fourth < fifth))
                                    {
                                        Console.WriteLine($"{first} {second} {third} {fourth} {fifth}");
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if((b-a)<5)
            {
                Console.WriteLine("No");
            }
        }
    }
}
