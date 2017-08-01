using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_7
{
    class Program
    {
        static string isPrimeNaive(int N)
        {
            if (N < 2)
                return "Not Prime";
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                    return "Not Prime";
            }
            return "Prime";
        }
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(isPrimeNaive(number));
            
        }
    }
}
