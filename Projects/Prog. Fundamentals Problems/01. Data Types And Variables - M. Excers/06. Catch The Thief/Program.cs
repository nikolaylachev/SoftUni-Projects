using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Catch_The_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            byte numberOfIDs = byte.Parse(Console.ReadLine());
            long number = 0;
            long max = 0;
            if (numeralType == "sbyte")
            {
                number = long.Parse(Console.ReadLine());
                max = number;
                for (int i = 1; i <= numberOfIDs - 1; i++)
                {
                    number = long.Parse(Console.ReadLine());
                    if (max < number && (number <= sbyte.MaxValue))
                    {
                        max = number;
                    }
                }
                Console.WriteLine(max);
            }
            if (numeralType == "int")
            {
                number = long.Parse(Console.ReadLine());
                max = number;
                for (int i = 1; i <= numberOfIDs - 1; i++)
                {
                    number = long.Parse(Console.ReadLine());
                    if (max < number && number <= int.MaxValue)
                    {
                        max = number;
                    }
                }
                Console.WriteLine(max);
            }
            if (numeralType == "long")
            {
                number = long.Parse(Console.ReadLine());
                max = number;
                for (int i = 1; i <= numberOfIDs - 1; i++)
                {
                    number = long.Parse(Console.ReadLine());
                    if (max < number && number <= long.MaxValue)
                    {
                        max = number;
                    }
                }
                Console.WriteLine(max);
            }
        }
    }
}
