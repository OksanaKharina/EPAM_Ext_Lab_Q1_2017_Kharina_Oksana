using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Round : Circle
    {
        /// <summary>
        /// площадь круга
        /// </summary>
        /// <returns></returns>
        public double ComArea(int r)
        {
            return Math.PI * r * r;
        }
    }
}
