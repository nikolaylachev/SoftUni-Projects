using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            
            for (int i = 0; i < numbers.Count;)
            {
                if (i < numbers.Count -1)
                {
                    if (numbers[i] == numbers[i + 1])
                    {
                        numbers.Insert(i, numbers[i] + numbers[i + 1]);
                        numbers.RemoveAt(i + 1);
                        numbers.RemoveAt(i + 1);
                        i = 0;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (i == numbers.Count-1)
                {
                    if (numbers.Count > 1 && numbers[i] == numbers[i-1])
                    {
                        numbers.Insert(i - 1, numbers[i] + numbers[i - 1]);
                        numbers.RemoveAt(i - 1);
                        numbers.RemoveAt(i - 1);
                    }
                    else
                    {
                        break;
                    }
                }
                
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
