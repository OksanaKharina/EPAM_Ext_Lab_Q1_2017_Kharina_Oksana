using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    /// <summary>
    /// Написать класс Round, задающий круг с указанными координатами центра,
    /// радиусом, а также свойствами, позволяющими узнать длину описанной окружности 
    /// и площадь круга. Обеспечить нахождение объекта в заведомо корректном состоянии. 
    /// Написать программу, демонстрирующую использование данного круга. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;
            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");

            do
            {
                try
                {
                    Console.WriteLine("Введите радиус круга: ");

                    Round round = new Round();
                    round.r = Convert.ToInt16(Console.ReadLine());
                    round.Radius = round.r;
                    if (round.r > 0)
                    {
                        var length = round.ComLength();
                        var area = round.ComArea();
                        Circle wrRound = new Circle();
                        wrRound.writeRound((int)length, (int)area);
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