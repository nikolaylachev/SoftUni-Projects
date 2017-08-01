using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Arrays___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 09 - Jump Around
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            for (int i = 0; i < arr.Length;)
            {
                
                if (i==0)
                {
                    sum += arr[i];
                    if ((i + arr[i]) < arr.Length)
                    {
                        i += arr[i];
                        sum += arr[i];
                    }
                    if (i-arr[i] >=0)
                    {

                    }
                    if ((i - arr[i]) < 0 && (i + arr[i]) >= arr.Length)
                    {
                        //sum += arr[i];
                        break;
                    }
                }


                else if (i>0)
                {
                    if ((i+arr[i]) < arr.Length)
                    {
                        i += arr[i];
                        sum += arr[i];
                        
                    }

                    else if ((i + arr[i]) >= arr.Length)
                    {
                        if ((i + arr[i]) < arr.Length)
                        {
                            i += arr[i];
                            sum += arr[i];
                        }

                        if ((i - arr[i]) >= 0)
                        {
                            i -= arr[i];
                            sum += arr[i];
                        }
                    }
                    if ((i - arr[i]) < 0 && (i + arr[i]) >= arr.Length)
                    {
                        //sum += arr[i];
                        break;
                    } 
                }

            }
            Console.WriteLine(sum);
        }
    }
}
