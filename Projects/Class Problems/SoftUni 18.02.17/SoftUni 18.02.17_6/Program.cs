using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_18._02._17_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string number = Console.ReadLine();
            
            for (int i = 0; i < number.Length; i++)
            {
               
                sum+= (int)char.GetNumericValue(number[i]);
                
            }
            Console.WriteLine(sum);
        }
    }
}
