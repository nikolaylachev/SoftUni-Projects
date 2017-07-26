using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            /* List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
             List<long> subsequences = new List<long>();
             List<long> bestSubsequences = new List<long>();
             string bestSeuqunces = string.Empty;
             for (int i = 0; i < numbers.Count; i++)
             {
                 if (i < numbers.Count-1)
                 {
                     if (numbers[i] < numbers[i+1])
                     {
                         subsequences.Add(numbers[i]);
                         //subsequences.Add(numbers[i+1]);
                     }
                     else if ((i > 0) && numbers[i] >= numbers[i+1])
                     {
                         if ((i-1) > 0 && numbers[i] > numbers[i-1])
                         {
                             subsequences.Add(numbers[i]);
                             //bestSubsequences.Add(numbers[i]);
                         }
                     }
                 }
                 else if (i == numbers.Count-1)
                 {
                     if ( numbers[i] > numbers[i-1])
                     {
                         subsequences.Add(numbers[i]);
                         //bestSubsequences.Add(numbers[i]);
                     }
                 }
             }
             Console.WriteLine(string.Join(" ",subsequences));
             for (int i = 0; i < subsequences.Count-1; i++)
             {
                 if (subsequences[i] >= subsequences[i+1])
                 {
                     int currentElementIndex = i;
                     for (int j = i; j < subsequences.Count; j++)
                     {
                         if (subsequences[j] > subsequences[currentElementIndex-1] && subsequences[j] < subsequences[currentElementIndex])
                         {
                             bestSubsequences.Add(subsequences[j]);
                         }
                     }
                 }
             }
            // Console.WriteLine(bestSeuqunces);
             Console.WriteLine(string.Join(" ",bestSubsequences));*/

            List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            Dictionary<string,long> allSubsequences  = new Dictionary<string, long>();
            long subsuquenceCounter = 0L;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i < numbers.Count-1)
                {
                    if (numbers[i] < numbers[i+1])
                    {
                        subsuquenceCounter++;
                        allSubsequences[numbers[i].ToString()] = subsuquenceCounter;
                    }
                    else if (numbers[i] > numbers[i+1])
                    {
                        if ((i - 1 >= 0) && numbers[i] > numbers[i-1])
                        {
                            subsuquenceCounter++;
                            allSubsequences[numbers[i].ToString()] = subsuquenceCounter;
                            subsuquenceCounter = 0;
                        }
                    }
                }
                else if (i == numbers.Count-1)
                {
                    if (numbers[i] > numbers[i-1])
                    {
                        subsuquenceCounter++;
                        allSubsequences[numbers[i].ToString()] = subsuquenceCounter;
                        subsuquenceCounter = 0;
                    }
                }
            }
            Console.WriteLine(string.Join(", ",allSubsequences));
            for (int i = 0; i < numbers.Count-1; i++)
            {
                if ((i > 0) && numbers[i] > numbers[i+1])
                {
                    int biggestElementIndexInSequence = i;
                    for (int j =biggestElementIndexInSequence ; j < numbers.Count; j++)
                    {
                        if (numbers[j] > numbers[biggestElementIndexInSequence-1] && numbers[j] < numbers[biggestElementIndexInSequence])
                        {

                            subsuquenceCounter++;
                            //allSubsequences[numbers[j].ToString()] = subsuquenceCounter;
                            
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(", ", allSubsequences));
        }
    }
}
