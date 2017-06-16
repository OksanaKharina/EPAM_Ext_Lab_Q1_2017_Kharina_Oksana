using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    /// <summary>
    /// Создать класс Ring (кольцо), описываемое координатами центра, 
    /// внешним и внутренним радиусами, а также свойствами, 
    /// позволяющими узнать площадь кольца и суммарную длину 
    /// внешней и внутренней границ кольца. 
    /// Обеспечить нахождение класса в заведомо корректном состоянии. 
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
                    Console.WriteLine("Введите радиус внутреннего и внешнего круга: ");

                    Round round = new Round();
                    round.r = Convert.ToInt16(Console.ReadLine());
                    round.Radius = round.r;
                    if (round.r > 0)
                    {
                        round.R = Convert.ToInt16(Console.ReadLine());
                        round.Radius = round.R;

                        if (round.R > 0)
                        {
                            var length = round.ComLength(round.R) + round.ComLength(round.r);
                            var area = Math.Abs(round.ComArea(round.R) - round.ComArea(round.r));
                            Circle wrRound = new Circle();
                            wrRound.writeRound((int)length, (int)area);
                        }
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
