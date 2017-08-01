using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long[] commandArr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            List<long> newNumbersList = new List<long>();
            bool isNumberInTheList = false;
            for (int i = 0; i < commandArr[0]; i++)
            {
                newNumbersList.Add(numbers[i]);
            }
            //for (int i = 0; i < commandArr[1]; i++)
            {
                newNumbersList.RemoveRange(0, (int)commandArr[1]);
            }
            foreach (var item in newNumbersList)
            {
                if (item == commandArr[2])
                {
                    isNumberInTheList = true;
                }
            }
            if (isNumberInTheList == true)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
