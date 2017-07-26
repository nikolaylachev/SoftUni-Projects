using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hands_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pesho: 2C, 4H, 9H, AS, QS
            Dictionary<string, long> powers = new Dictionary<string, long>();
            powers["2"] = 2; powers["3"] = 3; powers["4"] = 4; powers["5"] = 5; powers["6"] = 6; powers["7"] = 7; powers["8"] = 8;
            powers["9"] = 9; powers["10"] = 10; powers["J"] = 11; powers["Q"] = 12; powers["K"] = 13; powers["A"] = 14;
            Dictionary<string, long> types = new Dictionary<string, long>();
            types["C"] = 1; types["D"] = 2; types["H"] = 3; types["S"] = 4;

            Dictionary<string, List<string>> pointsOfPeople = new Dictionary<string, List<string>>();
            Dictionary<string, List<long>> pointsOfPeopleLong = new Dictionary<string, List<long>>();
            var distinctedList = new List<List<string>>();
            List<string> message;
           // long sum = 0L;

            //do
            //{
                message = Console.ReadLine().Split(new Char[] { ' ', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (!pointsOfPeople.ContainsKey(message[0]))
                {
                    pointsOfPeople.Add(message[0], message);
                    pointsOfPeople[message[0]].RemoveAt(0);//Deletes the key.
                    distinctedList = pointsOfPeople.Values.Distinct().ToList();
                    foreach (var power in powers)
                    {
                        foreach (var type in types)
                        {
                            
                            

                            
                        }
                    }
                }
                ////pointsOfPeople.Add(message[0], message);
                ////pointsOfPeople[message[0]].RemoveAt(0);
                //for (int i = 1; i < message.Count; i++)
                //{
                //    if (pointsOfPeople.ContainsKey(message[0]))
                //    {
                //        foreach (var p in power)
                //        {
                //            foreach (var t in type)
                //            {
                //                if (!message[i].Contains("1"))
                //                {
                //                    if (p.Key == Convert.ToString(message[i][0]) && t.Key == Convert.ToString(message[i][1]))
                //                    {
                //                        //pointsOfPeopleLong.Add(message[0], p.Value * t.Value);
                //                        //pointsOfPeopleLong[message[0]] = p.Value * t.Value;
                //                        //sum += pointsOfPeopleLong[message[0]];
                //                        sum += p.Value * t.Value;
                //                        pointsOfPeopleLong[message[0]] = sum;
                //                    } 
                //                }
                //                else if (message[i].Contains("1"))
                //                {
                //                    if (p.Key == Convert.ToString(message[i][0]) && t.Key == Convert.ToString(message[i][1]))
                //                    {
                //                        //pointsOfPeopleLong.Add(message[0], p.Value * t.Value);
                //                        //pointsOfPeopleLong[message[0]] = p.Value * t.Value;
                //                        //sum += pointsOfPeopleLong[message[0]];
                //                        sum += p.Value * t.Value;
                //                        pointsOfPeopleLong[message[0]] = sum;
                //                    }
                //                }
                //            }
                //        }
                //    }
                //    else if(!pointsOfPeople.ContainsKey(message[0]))
                //    {
                //        sum = 0L;
                //        //pointsOfPeople[message[0]] = message[i].ToList();
                //        pointsOfPeople.Add(message[0], message);
                //        pointsOfPeople[message[0]].RemoveAt(0);
                //        foreach (var p in power)
                //        {
                //            foreach (var t in type)
                //            {
                //                if (p.Key == Convert.ToString(message[i][0]) && t.Key == Convert.ToString(message[i][1]))
                //                {
                //                    //pointsOfPeopleLong.Add(message[0], p.Value * t.Value);
                //                    //pointsOfPeopleLong[message[0]] = p.Value * t.Value;
                //                    //sum += pointsOfPeopleLong[message[0]];
                //                    sum += p.Value * t.Value;
                //                    pointsOfPeopleLong[message[0]] = sum;
                //                }
                //            }
                //        }
                //    } 
                //}
                ////sum = 0L;
            //} while (message[0] != "JOKER");

            Console.WriteLine(string.Join(", ", pointsOfPeopleLong));
            foreach (var item in distinctedList)
            {
                Console.WriteLine(string.Join(", ", item)); 
            }
        }

        //foreach (var p in power)
        //{
        //    foreach (var t in type)
        //    {
        //        if (p.Key == "2" && t.Key == "S")
        //        {
        //            Console.WriteLine(p.Value*t.Value);
        //        }
        //    }
        //}
        //string[] arr = { "one", "two", "three" };
        //Console.WriteLine(arr[0][1]);
        //Console.WriteLine(Convert.ToUInt32('2') * Convert.ToUInt32('C'));
    }
}
