using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    class Field
    {
        public const int Width = 70;
        public const int Height = 50;
        //представим поле в виде пронумерованных клеток
        public Array arrField()
        {
            int k = 1;
            int[,] arr = new int[15, 11];

            for (int i = 0; i < 14; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = k;
                    k++;
                    Console.Write("{0}\t", arr[i, j]);
                }
                Console.WriteLine();
            }
            return arr;
        }        
    }
}
