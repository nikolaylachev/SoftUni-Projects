using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Dectypting_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            byte key = byte.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            string message = string.Empty;
            for (byte i= 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                if (letter >= 'a' && letter <= 'z' || letter >= 'A' && letter <= 'Z')
                {
                    message += letter;
                }
            }

            int[] arr = new int[message.Length];
            for (int i = 0; i < message.Length; i++)
            {
                arr[i] = (int)(message[i] + key);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write((char)arr[i]);
            }
        }
    }
}
