using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_OOP__1_st_try_
{
    class Rectangle
    {
        public int m_width=0;//private by deafult
        public int m_height = 0;//-||-

        public Rectangle(int width, int height)//Constructor
        {
            m_width=width;
            m_height = height;
        }

        public int getArea()
        {
            return (m_width * m_height);
        }

        public int getPerimeter()
        {
            return ((2*m_width) + (2*m_height));
        }
         
        ~Rectangle()//No access modifier!!!
        {
            Console.WriteLine("Destructor called! Object destroyed!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(2,5);
            Console.WriteLine(r1.getArea());
            Console.WriteLine(r1.getPerimeter());
             
           
        }
    }
}
