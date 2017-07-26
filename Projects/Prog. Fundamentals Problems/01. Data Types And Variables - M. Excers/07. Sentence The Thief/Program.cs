using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_The_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeralType = Console.ReadLine();
            sbyte n = sbyte.Parse(Console.ReadLine());
            long number=0L;
            long max = 0L;
            double sentence=0.0D;

            if (numeralType == "sbyte")
            {
                number = long.Parse(Console.ReadLine());
                max = number;
                for (int i = 1; i <= n - 1; i++)
                {
                    number = long.Parse(Console.ReadLine());
                    if (max < number && (number <= sbyte.MaxValue))
                    {
                        max = number;
                    }
                }
               // Console.WriteLine(max);
                if (max > 0)
                {
                    sentence = max / 127.00D;
                }
                else if (max < 0)
                {
                    sentence = max / -128.00D;
                }
                //Console.WriteLine((Math.Ceiling(sentence)));
                if (Math.Ceiling(sentence) == 1)
                {
                    Console.WriteLine($"Prisoner with id {max} is sentenced to {Math.Ceiling(sentence)} year");
                }
                else if (Math.Ceiling(sentence) > 1)
                {
                    Console.WriteLine($"Prisoner with id {max} is sentenced to {Math.Ceiling(sentence)} years");
                }
            }

            if (numeralType == "int")
            {
                number = long.Parse(Console.ReadLine());
                max = number;
                for (int i = 1; i <= n - 1; i++)
                {
                    number = long.Parse(Console.ReadLine());
                    if (max < number && number <= int.MaxValue)
                    {
                        max = number;
                    }
                }
                //Console.WriteLine(max);
                if (max > 0)
                {
                    sentence = max / 127.00D;
                }
                else if (max < 0)
                {
                    sentence = max / -128.00D;
                }
                //Console.WriteLine((Math.Ceiling(sentence)));
                if (Math.Ceiling(sentence) == 1)
                {
                    Console.WriteLine($"Prisoner with id {max} is sentenced to {Math.Ceiling(sentence)} year");
                }
                else if (Math.Ceiling(sentence) > 1)
                {
                    Console.WriteLine($"Prisoner with id {max} is sentenced to {Math.Ceiling(sentence)} years");
                }
            }

            if (numeralType == "long")
            {
                number = long.Parse(Console.ReadLine());
                max = number;
                for (int i = 1; i <= n - 1; i++)
                {
                    number = long.Parse(Console.ReadLine());
                    if (max < number && number <= long.MaxValue)
                    {
                        max = number;
                    }
                }
                //Console.WriteLine(max);
                if (max > 0)
                {
                    sentence = max / 127.00D;
                }
                else if (max < 0)
                {
                    sentence = max / -128.00D;
                }

                if (Math.Ceiling(sentence) == 1)
                {
                    Console.WriteLine($"Prisoner with id {max} is sentenced to {Math.Ceiling(sentence)} year"); 
                }
                else if (Math.Ceiling(sentence) > 1)
                {
                    Console.WriteLine($"Prisoner with id {max} is sentenced to {Math.Ceiling(sentence)} years");
                }
            }
        }
    }
}
