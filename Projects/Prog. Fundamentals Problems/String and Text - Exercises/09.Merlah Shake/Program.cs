using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Merlah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var key = Console.ReadLine();

            while (true)
            {
                var leftIndex = input.IndexOf(key);
                var rightIndex = input.LastIndexOf(key);

                var leftKeyExist = leftIndex != -1;
                var rightKeyExist = rightIndex != -1;
                var leftIndexAndRightIndexAreEqual = leftIndex == rightIndex;

                var keyIsEmpty = key == string.Empty;

                if (leftKeyExist && rightKeyExist && !leftIndexAndRightIndexAreEqual && !keyIsEmpty)
                {
                    input = input.Remove(rightIndex, key.Length);
                    input = input.Remove(leftIndex, key.Length);

                    Console.WriteLine("Shaked it.");
                    key = key.Remove(key.Length / 2, 1);
                }

                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
