using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public abstract class Figure
    {
        double a;
        double b;
        double c;
        public Figure(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public abstract double Perimetr();
        public abstract double Area();
    }
}
