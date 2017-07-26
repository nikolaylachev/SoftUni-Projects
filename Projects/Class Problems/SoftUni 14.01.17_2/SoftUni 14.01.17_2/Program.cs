using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_14._01._17_2
{
    class Program
    {
        static void Main(string[] args)
        {//                        m to mm , cm , mi , in , km , ft , yd
            double mm = 1000 ,cm= 100 ,mi= 0.000621371192 ,inches= 39.3700787 ,km= 0.001 ,ft= 3.2808399 ,yd= 1.0936133 ;
            double distance = double.Parse(Console.ReadLine());
            string convertFrom = Console.ReadLine();
            string convertTo = Console.ReadLine();
            switch (convertFrom)
            {
                case "m":
                    {
                        if(convertTo == "m")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo=="mm")
                        {
                            Console.WriteLine("{0} mm",distance*mm);
                        }
                        if (convertTo=="cm")
                        {
                            Console.WriteLine("{0} cm", distance*cm);
                        }
                        if (convertTo=="mi")
                        {
                            Console.WriteLine("{0} mi",distance*mi);
                        }
                        if (convertTo=="in")
                        {
                            Console.WriteLine("{0} in",distance*inches);
                        }
                        if (convertTo=="km")
                        {
                            Console.WriteLine("{0} km",distance*km);
                        }
                        if (convertTo=="ft")
                        {
                            Console.WriteLine("{0} ft",distance*ft);
                        }
                        if (convertTo=="yd")
                        {
                            Console.WriteLine("{0} yd",distance*yd);
                        }
                       
                    }
                    break;

                case "mm":
                    {
                        if (convertTo=="mm")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo=="m")
                        {
                            Console.WriteLine("{0} m", distance /mm);
                        }
                        if (convertTo == "cm")
                        {
                            Console.WriteLine("{0} cm", (distance /mm)*cm);
                        }
                        if (convertTo=="mi")
                        {
                            Console.WriteLine("{0} mi", (distance/mm)*mi);
                        }
                        if (convertTo=="in")
                        {
                            Console.WriteLine("{0} in", (distance/mm)*inches);
                        }
                        if (convertTo=="km")
                        {
                            Console.WriteLine("{0} km", (distance/mm)*km);
                        }
                        if (convertTo=="ft")
                        {
                            Console.WriteLine("{0} ft", (distance/mm)*ft);
                        }
                        if (convertTo=="yd")
                        {
                            Console.WriteLine("{0} yd", (distance/mm)*yd);
                        }
                    }
                    break;

                case "cm":
                    {
                        if(convertTo == "cm")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo == "m")
                        {
                            Console.WriteLine("{0} m", distance / cm);
                        }
                        if (convertTo=="mm")
                        {
                            Console.WriteLine("{0} mm", (distance/cm)*mm);
                        }
                        if (convertTo=="mi")
                        {
                            Console.WriteLine("{0} mi", (distance/cm)*mi);
                        }
                        if (convertTo == "in")
                        {
                            Console.WriteLine("{0} in", (distance / cm)*inches);
                        }
                        if (convertTo == "km")
                        {
                            Console.WriteLine("{0} fm", (distance / cm)*km);
                        }
                        if (convertTo == "ft")
                        {
                            Console.WriteLine("{0} ft", (distance / cm)*ft);
                        }
                        if (convertTo == "yd")
                        {
                            Console.WriteLine("{0} yd", (distance / cm)*yd);
                        }
                    }
                    break;

                case "mi":
                    {
                        if(convertTo == "mi")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo == "m")
                        {
                            Console.WriteLine("{0} m", (distance / mi));
                        }
                        if (convertTo == "mm")
                        {
                            Console.WriteLine("{0} mm", (distance / mi)*mm);
                        }
                        if (convertTo == "cm")
                        {
                            Console.WriteLine("{0} cm", (distance / mi)*cm);
                        }
                        if (convertTo == "in")
                        {
                            Console.WriteLine("{0} in", (distance / mi)*inches);
                        }
                        if (convertTo=="km")
                        {
                            Console.WriteLine("{0} km", (distance /mi)*km);
                        }
                        if (convertTo == "ft")
                        {
                            Console.WriteLine("{0} ft", (distance / mi)*ft);
                        }
                        if (convertTo == "yd")
                        {
                            Console.WriteLine("{0} yd", (distance / mi)*yd);
                        }

                    }
                    break;

                case "in":
                    {
                        if(convertTo == "in")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo == "m")
                        {
                            Console.WriteLine("{0} m", (distance /inches));
                        }
                        if (convertTo == "mm")
                        {
                            Console.WriteLine("{0} mm", (distance / inches)*mm);
                        }
                        if (convertTo == "cm")
                        {
                            Console.WriteLine("{0} cm", (distance / inches)*cm);
                        }
                        if (convertTo == "km")
                        {
                            Console.WriteLine("{0} km", (distance / inches)*km);
                        }
                        if (convertTo == "ft")
                        {
                            Console.WriteLine("{0} ft", (distance / inches)*ft);
                        }
                        if (convertTo == "yd")
                        {
                            Console.WriteLine("{0} yd", (distance / inches)*yd);
                        }
                        if (convertTo == "mi")
                        {
                            Console.WriteLine("{0} mi", (distance / inches)*mi);
                        }

                    }
                    break;

                case "km":
                    {
                        if(convertTo == "km")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo == "m")
                        {
                            Console.WriteLine("{0} km", (distance /km));
                        }
                        if (convertTo == "mm")
                        {
                            Console.WriteLine("{0} mm", (distance / km)*mm);
                        }
                        if (convertTo == "cm")
                        {
                            Console.WriteLine("{0} cm", (distance / km)*cm);
                        }
                        if (convertTo == "mi")
                        {
                            Console.WriteLine("{0} mi", (distance / km)*mi);
                        }
                        if (convertTo == "in")
                        {
                            Console.WriteLine("{0} in", (distance / km)*inches);
                        }
                        if (convertTo == "ft")
                        {
                            Console.WriteLine("{0} ft",(distance / km)*ft);
                        }
                        if (convertTo == "yd")
                        {
                            Console.WriteLine("{0} yd", (distance / km)*yd);
                        }
                    }
                    break;

                case "ft":
                    {
                        if (convertTo == "ft")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo == "m")
                        {
                            Console.WriteLine("{0} m", (distance / ft));
                        }
                        if (convertTo == "mm")
                        {
                            Console.WriteLine("{0} mm", (distance / ft)*mm);
                        }
                        if (convertTo == "cm")
                        {
                            Console.WriteLine("{0} cm", (distance / ft)*cm);
                        }
                        if (convertTo == "mi")
                        {
                            Console.WriteLine("{0} mi", (distance / ft)*mi);
                        }
                        if (convertTo == "km")
                        {
                            Console.WriteLine("{0} km", (distance / ft)*km);
                        }
                        if (convertTo == "in")
                        {
                            Console.WriteLine("{0} in", (distance / ft)*inches);
                        }
                        if (convertTo == "yd")
                        {
                            Console.WriteLine("{0} yd", (distance / ft)*yd);
                        }
                    }
                    break;

                case "yd":
                    {
                        if (convertTo == "yd")
                        {
                            Console.WriteLine(distance);
                        }
                        if (convertTo == "m")
                        {
                            Console.WriteLine("{0} m", (distance / yd));
                        }
                        if (convertTo == "mm")
                        {
                            Console.WriteLine("{0} mm", (distance / yd)*mm);
                        }
                        if (convertTo == "cm")
                        {
                            Console.WriteLine("{0} cm", (distance / yd)*cm);
                        }
                        if (convertTo == "km")
                        {
                            Console.WriteLine("{0} km", (distance / yd)*km);
                        }
                        if (convertTo == "mi")
                        {
                            Console.WriteLine("{0} mi", (distance / yd)*mi);
                        }
                        if (convertTo == "in")
                        {
                            Console.WriteLine("{0} in", (distance / yd) * inches);
                        }
                        if (convertTo=="ft")
                        {
                            Console.WriteLine("{0} ft", (distance /yd)*ft);
                        }
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
