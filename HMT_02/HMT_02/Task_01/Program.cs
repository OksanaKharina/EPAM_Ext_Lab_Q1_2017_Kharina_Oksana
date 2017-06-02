using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    /// <summary>
    /// Написать программу, которая определяет площадь прямоугольника
    /// со сторонами a и b. Если пользователь вводит некорректные значения 
    /// (отрицательные или 0), должны выдаваься сообщение об ошибке.
    /// Возможность ввода пользователем строки вида "абвгд" или нецелых чисел
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.CursorVisible = false;
            int s = 0;
            while (s == 0)
            {
                Console.WriteLine("Введите числа a и b, чтобы вычислить прямоугольник. a и b > 0 !!!");
                try
                {
                    Console.Write("a = ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.Write("b = ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a > 0 && b > 0)
                    {
                        s = a * b;
                        Console.WriteLine("Площадь прямоугольника со сторонами a = {0}, b = {1}, равна s = {2}", a, b, s);
                    }
                    else
                    {
                        Console.WriteLine("a и b < = 0. Попробуйте еще раз.");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
            }
    }
}
