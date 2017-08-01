using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Cake_Candles
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            //List<int> candles = new List<int>(n);
            int[] candles = new int[n];

            candles = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();//.ToList();

            Dictionary<int, int> candlesCount = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (!candlesCount.ContainsKey(candles[i]))
                {
                    candlesCount[candles[i]] = 1;
                }
                else if (candlesCount.ContainsKey(candles[i]))
                {
                    candlesCount[candles[i]]++;
                }
            }

            var maxKey = int.MinValue;
            var maxKeyValue = int.MinValue;

            foreach (var candle in candlesCount)
            {
                if (candle.Key > maxKey)
                {
                    maxKey = candle.Key;
                    maxKeyValue = candle.Value;
                }
            }

            Console.WriteLine(maxKeyValue);
        }
    }
}
