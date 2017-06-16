using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Line
    {
        public double x { get; set; }
        public double y { get; set; }

        public Line (double x, double y)
        {     
            this.x = x;
            this.y = y;
        }
        public double Length()
        {
            return Math.Abs(x - y);
        }
    }
}
