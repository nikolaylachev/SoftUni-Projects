using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Logs_Aggregator
{
    class Program
    {
        class LogIns
        {
            public string name { get; set; }
            public string ip { get; set; }
            public long duration { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> command = new List<string>()
            {
                "c","aaa","bb"
            };
            var numbers = command.OrderBy(x => x.Length).Select(x => x.ToUpper());
            foreach (var item in numbers)
            {
                Console.WriteLine(item); 
            }
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            
            dic["alex"] = new List<string>() { "1","2","3"};
            
            Dictionary<string, Dictionary<string, List<long>>> logIns = new Dictionary<string, Dictionary<string, List<long>>>();
            {
                logIns["alex"] = new Dictionary<string, List<long>>();
            }

            //for (int i = 1; i <= n; i++)
            //{
            //    command = Console.ReadLine().Split(' ').ToList();// [0] -> ip, [1] -> name, [2] -> duration
            //    if (!logIns.ContainsKey(command[1]))
            //    {
            //        //logIns.Add(command[1],(List<>)command[0]);
            //    }
            //    else if (logIns.ContainsKey(command[1]))
            //    {

            //    }
            //}




















            //List<string> message = new List<string>();
            //Dictionary<string, List<string>> LogIns = new Dictionary<string, List<string>>();
            //long sum = 0L;
            //string ipAddress = "";
            //string index = "";
            //string duration = "";
            //for (int i = 1; i <= n; i++)
            //{
            //    message = Console.ReadLine().Split(' ').ToList();//[0] -> IP address, [1] -> name, [2] -> duration
            //    if (!LogIns.ContainsKey(message[1]))
            //    {
            //        sum = 0L;
            //        index = message[1];
            //        LogIns.Add(message[1],message);
            //        LogIns[message[1]].RemoveAt(1);
            //        sum += Convert.ToInt64(LogIns[index][1]);
            //    }
            //    else if (LogIns.ContainsKey(message[1]))
            //    {
            //        ipAddress = message[0];

            //        if (ipAddress == LogIns[message[1]][0])
            //        {
            //            index = message[1];
            //            duration = message[2];
            //            //LogIns.Add(message[1], message);
            //            //LogIns[message[1]].RemoveAt(1);
            //            LogIns[index].Insert(1, duration);
            //            sum += Convert.ToInt64(LogIns[index][1]); 
            //        }
            //        else if (ipAddress != LogIns[message[1]][0])
            //        {
            //            index = message[1];
            //            duration = message[2];
            //            LogIns[index].Insert(0, ipAddress);
            //            //LogIns[index].RemoveAt(1);
            //            LogIns[index].Insert(1, duration);
            //            //LogIns[index].RemoveAt(2);
            //            sum += Convert.ToInt64(LogIns[index][1]);
            //        }
            //    }

            //}
            //Console.WriteLine(LogIns[message[1]][1]);
            //Console.WriteLine(sum);
        }
    }
}
