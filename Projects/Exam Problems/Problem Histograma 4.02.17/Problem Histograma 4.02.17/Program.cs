using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Histograma_4._02._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] array = new int [size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            double p1=0, p2=0, p3=0, p4=0, p5=0;
            for (int i = 0; i < size; i++)
            {
                if (array[i] < 200)
                {
                    p1++;
                }
                if (array[i] >= 200 && array[i] < 400)
                {
                    p2++;
                }
                if (array[i] >= 400 && array[i] < 600)
                {
                    p3++;
                }
                if (array[i] >= 600 && array[i] < 800)
                {
                    p4++;
                }
                if (array[i] >= 800)
                {
                    p5++;
                }
            }
                Console.WriteLine("{0:f2}",(p1/size)*100); //p1/size;
                Console.WriteLine("{0:f2}",(p2/size)*100);
                Console.WriteLine("{0:f2}",(p3/size)*100);
                Console.WriteLine("{0:f2}",(p4/size)*100);
                Console.WriteLine("{0:f2}",(p5/size)*100);
            
        }
    }
}
