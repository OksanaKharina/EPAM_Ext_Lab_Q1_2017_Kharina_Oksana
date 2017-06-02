using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    /// <summary>
    /// Написать программу, которая выводит на экран сумму всех чисел
    /// меньше 1000, кратных 3 или 5
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.CursorVisible = false;
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3) == 0 || (i % 5) == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine("Сумма всех чисел меньше 1000 и кратных 3 или 5 равна: \n sum = {0}", sum);
            Console.ReadKey();
        }
    }
}
