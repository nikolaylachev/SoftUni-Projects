using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Electronics_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');//10 4 5
            int s = Convert.ToInt32(tokens_s[0]);//# of money 10
            int n = Convert.ToInt32(tokens_s[1]);//# of keyboard brands 4
            int m = Convert.ToInt32(tokens_s[2]);//# of usb brands 5
            string[] keyboards_temp = Console.ReadLine().Split(' ');
            int[] keyboards = Array.ConvertAll(keyboards_temp, Int32.Parse);//4 5 6 7
            string[] pendrives_temp = Console.ReadLine().Split(' ');
            int[] pendrives = Array.ConvertAll(pendrives_temp, Int32.Parse);//1 2 3 4 5

            int max = keyboards[0] + pendrives[0];
            int counter = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if ((keyboards[i] + pendrives[j]) < s)
                    {
                        if (((keyboards[i] + pendrives[j]) > max))
                        {
                            max = (keyboards[i] + pendrives[j]);
                            counter++;
                        } 
                    }
                    else if (keyboards[i] + pendrives[j] >= s )
                    {
                       
                    }
                }
            }
            if (counter > 0)
            {
                Console.WriteLine(max); 
            }
            if (counter == 0)
            {
                Console.WriteLine("-1");
            }
        }
    }
}
