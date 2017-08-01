using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Equal
{
    class Program
    {
        static Int64 MaxCounter(Int64 firstSum, Int64 secondSum , Int64 thirdSum , Int64 fourthSum , Int64 fifthSum)
        {
            if (firstSum >= secondSum && firstSum >= thirdSum && firstSum >= fourthSum && firstSum >= fifthSum)
            {
                return firstSum;
            }
            if (secondSum >= firstSum && secondSum >= thirdSum && secondSum >= fourthSum && secondSum >= fifthSum)
            {
                return secondSum;
            }
            if (thirdSum >= secondSum && thirdSum >= firstSum && thirdSum >= fourthSum && thirdSum >= fifthSum)
            {
                return thirdSum;
            }
            if (fourthSum >= secondSum && fourthSum >= thirdSum && fourthSum >= firstSum && fourthSum >= fifthSum)
            {
                return fourthSum;
            }
            if (fifthSum >= secondSum && fifthSum >= thirdSum && fifthSum >= fourthSum && fifthSum >= firstSum)
            {
                return fifthSum;
            }
            return 0;
        }
        static Int64 MinCounter(Int64 firstSum, Int64 secondSum, Int64 thirdSum, Int64 fourthSum, Int64 fifthSum)
        {
            if (firstSum <= secondSum && firstSum <= thirdSum && firstSum <= fourthSum && firstSum <= fifthSum)
            {
                return firstSum;
            }
            if (secondSum <= firstSum && secondSum <= thirdSum && secondSum <= fourthSum && secondSum <= fifthSum)
            {
                return secondSum;
            }
            if (thirdSum <= secondSum && thirdSum <= firstSum && thirdSum <= fourthSum && thirdSum <= fifthSum)
            {
                return thirdSum;
            }
            if (fourthSum <= secondSum && fourthSum <= thirdSum && fourthSum <= firstSum && fourthSum <= fifthSum)
            {
                return fourthSum;
            }
            if (fifthSum <= secondSum && fifthSum <= thirdSum && fifthSum <= fourthSum && fifthSum <= firstSum)
            {
                return fifthSum;
            }
            return 0;
        }
        static void result(int [] grades)
        {
            int lastDigit;
            for (int i = 0; i <= grades.Length; i++)
            {
                if (grades[i] >= 38)
                {
                    lastDigit = grades[i] % 10;
                    if (lastDigit > 0 && lastDigit < 5)//next multiple is ending with a 5
                    {
                        int difference = 5 - lastDigit;
                        if (difference < 3)
                        {
                            grades[i] += difference;
                        }
                        //Console.WriteLine(grades[i]);
                    }
                    if (lastDigit > 5)//next multiple is ending with a 0
                    {
                        int difference = 10 - lastDigit;
                        if (difference < 3)
                        {
                            grades[i] += difference;
                        }
                        //Console.WriteLine(grades[i]);
                    }
                }
            }
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }
        }
        static void minDifference(int n, int p)
        {
            Console.WriteLine(Math.Min(p/2,(n/2)-(p/2)));
        }
        static void Main(string[] args)
        {

            //Time Convertion.
            string time = Console.ReadLine();//07:05:45AM -> 07:05:45
            string time2 = string.Empty;
            if (time.Contains("AM") && time != "12:00:00AM")
            {
                time2 = time.Remove(8);
            }
            if (time == "12:00:00AM")
            {
                time2 = "00:00:00";
            }
            if (time == "12:00:00PM")
            {
                time2 = "12:00:00";
            }
            Console.WriteLine(time2);
            string[] time3 = Console.ReadLine().Split(':');
            if (time.Contains("PM"))
            {
                time2 = time.Remove(8);
            }
            int[] hh = Array.ConvertAll(time3, Int32.Parse);
            hh[0] += 12;
            for (int i = 0; i < hh.Length; i++)
            {
                if (i < hh.Length-1)
                {
                    if (hh[i]<10)
                    {
                        Console.Write("0{0}:",hh[i]);
                    }

                    else
                    {
                        Console.Write("{0}:", hh[i]);  
                    }
                }
                if (i== hh.Length-1)
                {
                    Console.WriteLine("{0}",hh[hh.Length-1]);
                }
            }
            
        }
    }
}
