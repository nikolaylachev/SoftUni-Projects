using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9_Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentAltitude = int.Parse(Console.ReadLine());
            string str = Console.ReadLine();
            string[] arr = str.Split(' ');
            

            /* for (int i = 0; i < str.Length; i++)
             {
                 if (str[i]=='u')
                 {

                         int j = i + 3;
                     do
                     {

                         if (char.IsDigit(str[j]))
                         {
                             upDigits += str[j];
                         }
                         j++;
                     }
                     while (str[j] != ' ');// ||  j <= str.Length); 
                 }

                 else if (str[i]=='d')
                 {
                     int j = i + 5;
                     do
                     {
                         if (char.IsDigit(str[j]))
                         {
                             downDigits += str[j];
                         }
                         j++;
                     }
                     while (str[j] != ' ');//|| j <= str.Length);
                 }
             }
             Console.WriteLine("upDigits = {0}, downDigits = {0}",upDigits,downDigits);*/
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (i%2!=0 && arr[i]=="up")
                {
                    //currentAltitude += (int) arr[i + 1];
                }
            }
           
        }
    }
}
