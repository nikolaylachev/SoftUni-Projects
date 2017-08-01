using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long[] bombNumberAndPowerArray = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            int count = 1;
            for (long i = 0L; i < numbers.Count; i++)
            {
                if (numbers[(int)i] == bombNumberAndPowerArray[0])
                {
                    long j = i;
                    count = 1;
                    while (count <= bombNumberAndPowerArray[1] && (j-1) >= 0)//First: Removing the elements before the bomb number.
                    {
                        if (numbers[(int)j] == bombNumberAndPowerArray[0])
                        {
                            numbers.RemoveAt((int)j - 1);
                            count++;
                            j--;
                        }      
                    }
                    count = 1;
                    while (count <= bombNumberAndPowerArray[1] && (j+1) < numbers.Count)//Second: Removing the elemets after the bomb number.
                    {
                        if (numbers[(int)j] == bombNumberAndPowerArray[0])
                        {
                            numbers.RemoveAt((int)j + 1);
                            count++;
                        }
                    }
                    numbers.RemoveAt((int)j);//Finally: Removing the bomb number.
                    if (numbers.Count == 1 && numbers[(int)j] == bombNumberAndPowerArray[0])
                    {
                        numbers.RemoveAt((int)j);
                    }
                }
            }
            Console.Write("Numbers = {");
            Console.Write(string.Join(" ",numbers));
            Console.WriteLine("}");
            Console.WriteLine(numbers.Sum());
        }
    }
}
