using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    /// <summary>
    /// Написать класс, описывающий треугольник со сторонами a, b, c, 
    /// и позволяющий осуществить расчёт его площади и периметра. 
    /// Написать программу, демонстрирующую использование данного треугольника. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;
            double a;
            double b;
            double c;

            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");
           
           
                do
                {
                try
                {
                    Console.Write("Введите строны прямоугольника\t a = ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.Write("b = ");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.Write("c = ");
                    c = Convert.ToDouble(Console.ReadLine());

                    Triangle triangle = new Triangle(a, b, c);

                    if (triangle.Existence(triangle.a, triangle.b, triangle.c) == true)
                    {
                        var perimetr = triangle.Perimetr();
                        Console.WriteLine("периметр P = {0} ", perimetr);
                        var area = triangle.Area();
                        Console.WriteLine("площадь S = {0} ", (int)area);
                    }
                    else
                    {
                        throw new Exception("a+b>c a+c>b b+c>a a>0 b>0 c>0");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
                while (Console.ReadKey().Key != ConsoleKey.Escape);            
       }
    }
}
