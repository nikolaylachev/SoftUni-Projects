using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цезаров_шифър
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string newMessage = String.Empty;
            int[] arr= new int [message.Length];

            /*for (int j = 1; j <= 25; j++)
            {


                for (int i = 0; i < message.Length; i++)
                {
                    arr[i] += ((int)message[i] + j);
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write((char)arr[i]);
                }
                Console.WriteLine();
            }*/
            for (int i = 0; i <= 64; i++)
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
