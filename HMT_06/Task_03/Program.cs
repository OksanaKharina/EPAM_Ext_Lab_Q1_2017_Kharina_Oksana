using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{

    /// <summary>
    /// Напишите заготовку для векторного графического редактора. 
    /// Полная версия редактора должна позволять создавать и 
    /// выводить на экран такие фигуры как: Линия, Окружность, 
    /// Прямоугольник, Круг, Кольцо. Заготовка, для упрощения, 
    /// должна представлять собой консольное приложение с функционалом:  
    /// 1. Создать фигуру выбранного типа по произвольным координатам.  
    /// 2. Вывести фигуры на экран (для каждой фигуры вывести 
    /// на консоль её тип и значения параметров). 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            const string display = "Вы ввели некорректные данные, попробуйте еще раз \n";

            int arg;
            double x, y;
            double a;
            double b;
            double r;
            double R;

            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");


            do
            {
                    Console.Write("Выберите тип фигуры: \n\t 1: Линия \n\t 2: Окружность \n\t 3: Круг \n\t 4: Кольцо \n\t 5: Прямоугольник \n\t 6: Выход \n");
                    arg = Convert.ToInt16(Console.ReadLine());

                    switch (arg) //isklychenia 5/2
                    {
                        case 1:
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Задайте координаты линии x и y\n");
                                x = Convert.ToDouble(Console.ReadLine());
                                y = Convert.ToDouble(Console.ReadLine());
                                Line l = new Line(x, y);
                                Console.WriteLine("Длина = {0}", l.Length());
                            }
                        catch (FormatException)
                            {
                            Console.Write(display);          
                            }
                        break;
                                   
                    case 2:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Задайте радиус окружности \n");
                            Circle c = new Circle();
                            c.r = Convert.ToDouble(Console.ReadLine());
                            c.Radius = (int)c.r;
                            if (c.r > 0)
                            { 
                            Console.WriteLine("Длина окружности = {0}", c.Length(c.r));
                            }
                        }
                        catch (FormatException)
                        {
                            Console.Write(display);
                        }
                        break;

                        case 3:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Задайте радиус круга \n");
                            Round c = new Round();
                            c.r = Convert.ToDouble(Console.ReadLine());
                            c.Radius = (int)c.r;
                            if (c.r > 0)
                            {
                                Console.WriteLine("\tДлина = {0} \n\tплощадь = {1}", c.Length(c.r), c.Area(c.r));
                            }
                        }
                        catch (FormatException)
                        {
                            Console.Write(display);
                        }
                        break;

                        case 4:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Задайте внутренний и внешний радиусы кольца \n");
                            Ring c = new Ring();
                            c.r = Convert.ToDouble(Console.ReadLine());
                            c.Radius = (int)c.r;
                            c.R = Convert.ToDouble(Console.ReadLine());
                            c.Radius = (int)c.R;
                            if (c.r > 0 && c.R > 0)
                            {
                                Console.WriteLine("\tДлина = {0} \n\tплощадь = {1}", c.Length(c.r, c.R), c.Area(c.r, c.R));
                            }
                        }
                        catch (FormatException)
                        {
                            Console.Write(display);
                        }
                        break;

                        case 5:
                        try
                        {
                            Console.Clear();
                            Console.WriteLine("Задайте длину и ширину прямоугольника\n");
                            a = Convert.ToDouble(Console.ReadLine());
                            b = Convert.ToDouble(Console.ReadLine());
                            Rectangle p = new Rectangle();
                            if (a >= 0 && b >= 0)
                            {
                                Console.WriteLine("\tПериметр = {0} \n\tплощадь = {1}", p.Perimetr(a, b), p.Area(a, b));
                                p.Square(a, b);
                            }
                            else
                            {
                                Console.WriteLine(display);
                            }
                        }
                        catch (FormatException)
                        {
                            Console.Write(display);
                        }
                        break;

                        case 6:
                        Environment.Exit(0);
                        break;
                    }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
