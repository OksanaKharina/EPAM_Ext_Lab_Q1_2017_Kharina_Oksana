using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Circle
    {
        public int x;
        public int y;
        public int r;
        public int R;

        /// <summary>
        /// длина окружности
        /// </summary>
        /// <returns></returns>
        public double ComLength(int r)
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
            Console.WriteLine("Суммарная длина внешней и внутренней границ кольца L = {0}, площадь кольца S = {1}", len, are);
        }
        public int Radius
        {
            get
            {
                return r;
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
