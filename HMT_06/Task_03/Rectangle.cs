using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Rectangle
    {
        public double a;
        public double b;
        public double Perimetr(double a, double b)
        {
            return 2 * (a + b);
        }
        public double Area(double a, double b)
        {
            return a * b;
        }
        public string Square(double a, double b)
        {
            if (a == b)
            {
                Console.WriteLine("\tВаш прямоугольник - квадрат");
            }
            return "";
        }
    }
}
