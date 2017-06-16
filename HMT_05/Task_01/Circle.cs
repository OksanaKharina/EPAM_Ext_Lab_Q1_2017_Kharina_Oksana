using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Circle
    {
        public int x;
        public int y;
        public int r;

        /// <summary>
        /// длина окружности
        /// </summary>
        /// <returns></returns>
        public double ComLength()
        {
            return 2 * Math.PI * r;
        }
        /// <summary>
        /// вывод значений по условию задачи
        /// </summary>
        /// <param name="len"></param>
        /// <param name="are"></param>
        public void writeRound(int len, int are)
        {
            Console.WriteLine("Длина окружности l = {0}, площадь круга S = {1}", len, are);
        }
        private int g;//todo pn на что тебе g, если у тебя есть r?
        public int Radius
        {
            get
            {
                return g;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Радиус отрицательным или равен нулю быть не может");
                }
                else
                {
                    g = value;
                }
            }
        }
    }
}
