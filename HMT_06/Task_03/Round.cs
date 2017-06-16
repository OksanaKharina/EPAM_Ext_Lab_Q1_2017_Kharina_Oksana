using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class Round : Circle
    {
        public double Area(double r)
        {
            return Math.PI * r * r;
        }
    }
}
