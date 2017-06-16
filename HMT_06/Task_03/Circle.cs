using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Circle
    {
        public double r;
        public double Length(double r)
        {
            return 2 * Math.PI * r;
        }
        public int Radius
        {
            get
            {
                return (int)r;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус отрицательным или равен нулю быть не может");
                }
                else
                {
                    r = value;
                }
            }
        }

    }
}
