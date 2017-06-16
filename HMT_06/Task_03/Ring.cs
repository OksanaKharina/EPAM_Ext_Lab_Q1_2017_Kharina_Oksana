using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Ring : Round
    {
        public double R;
        public new double r;
        public double Length(double R, double r)
        {
            return Length(R) - Length(r);
        }
        public double Area(double R, double r)
        {
            return Math.Abs(Area(R) - Area(r));
        }
    }
}
