using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank_Problem_Divisable_Sum_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            int x = 0, y = 0, z = 0;
            string result = string.Empty;
            for (int a0 = 0; a0 < q; a0++)
            {
                string[] tokens_x = Console.ReadLine().Split(' ');
                x = Convert.ToInt32(tokens_x[0]);
                y = Convert.ToInt32(tokens_x[1]);
                z = Convert.ToInt32(tokens_x[2]);
                if (Math.Abs(x - z) < Math.Abs(y - z))
                {
                    result += "Cat A  ";
                }
                else if (Math.Abs(x - z) > Math.Abs(y - z))
                {
                    result += "Cat B  ";
                }
                else if (Math.Abs(x - z) == Math.Abs(y - z))
                {
                    result += "Mouse C  ";
                }
            }
            //text = text.Replace("@", "@" + System.Environment.NewLine);
            result = result.Replace("  ", "  " + System.Environment.NewLine);
            Console.WriteLine(result);
        }
    }
}
