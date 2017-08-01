using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers___My_way
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> equalNumbers = new List<long>();
            List<long> count = new List<long>();
            int counter = 0;
            numbers.Sort();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count-1)
                {
                    if (numbers[i] == numbers[i+1])
                    {
                        counter++;
                    }
                    else if ((i > 0) && numbers[i] != numbers[i+1])
                    {
                        if (((i-1) >= 0) && numbers[i] == numbers[i-1])
                        {
                            counter++;
                            equalNumbers.Add(numbers[i]);
                            count.Add(counter);
                            counter = 0;
                        }
                        
                    }
                    if ((i > 0) && (i < numbers.Count - 1) && (numbers[i] != numbers[i-1]) && (numbers[i] != numbers[i+1]))
                    {
                        counter++;
                        equalNumbers.Add(numbers[i]);
                        count.Add(counter);
                        counter = 0;
                    }
                    if ((i==0) && (numbers[i] != numbers[i+1]))
                    {
                        counter++;
                        equalNumbers.Add(numbers[i]);
                        count.Add(counter);
                        counter = 0;
                    }
                }
                else if (i == numbers.Count-1)
                {
                    if (numbers[i] == numbers[i-1])
                    {
                        counter++;
                        equalNumbers.Add(numbers[i]);
                        count.Add(counter);
                        counter = 0;
                    }
                    else if(numbers[i] != numbers[i-1])
                    {
                        counter++;
                        equalNumbers.Add(numbers[i]);
                        count.Add(counter);
                        counter = 0;
                    }
                }
            }

            for (int i = 0; i < equalNumbers.Count; i++)
            {
                Console.WriteLine($"{equalNumbers[i]} -> {count[i]}");
            }
        }
    }
}
