using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Triangle : Figure
    {
        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public Triangle(double a, double b, double c) : base(a, b, c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        /// <summary>
        /// существование треугольника
        /// </summary>
        public bool Existence(double a, double b, double c)
        {
            if ( (a + b > c) && (a + c > b) && (b + c > a) && (a > 0) && (b > 0) && (c > 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// вычисление периметра
        /// </summary>
        /// <returns></returns>
        public override double Perimetr()
        {
            return a + b + c;
        }
        /// <summary>
        /// вычисление площади
        /// </summary>
        /// <returns></returns>
        public override double Area()
        {
            double Per = (Perimetr()) / 2;
            return (double)Math.Sqrt(Per * (Per - a) * (Per - b) * (Per - c));
        }
    }
}
