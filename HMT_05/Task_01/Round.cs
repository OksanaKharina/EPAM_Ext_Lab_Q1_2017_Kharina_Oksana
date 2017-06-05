using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
        public class Round : Circle 
        {
        /// <summary>
        /// площадь круга
        /// </summary>
        /// <returns></returns>
            public double ComArea()
            {
                return Math.PI * r * r;
            }
        }
    }
