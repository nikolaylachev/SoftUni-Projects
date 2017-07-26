using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF_Data_Types_And_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int numberOfCourses = 0;
            if (numberOfPeople % capacity == 0)
            {
                numberOfCourses = numberOfPeople / capacity;
                Console.WriteLine(numberOfCourses);
            }
            else if (numberOfPeople % capacity != 0)
            {
                numberOfCourses = (numberOfPeople / capacity) + 1;
                Console.WriteLine(numberOfCourses);
            }
        }
    }
}
