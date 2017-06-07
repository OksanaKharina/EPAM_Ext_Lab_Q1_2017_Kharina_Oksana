using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    /// <summary>
    /// Для выделения текстовой надписи можно использовать 
    /// выделение жирным, курсивом и подчёркиванием. 
    /// Предложите способ хранения информации 
    /// о выделении надписи и напишите программу, 
    /// которая позволяет назначать и удалять текстовой надписи 
    /// выделение
    /// </summary>
    class Program
    {
       enum Style
        {
            bold = 1,
            italic,
            underline,
            clear
        }
        /*static void MathOp( Style font)
        {
           

            Console.WriteLine("Параметры подписи: {0}", c);
        }*/
        static void Main(string[] args)//todo pn код не хранит предыдущие состояния текста. Всегда показывается только что выбранное.
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            int i = 0;
            string[][] arr = new string[4][];

            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");

            try
            {
                do
                {
                    Console.WriteLine("Введите: \n\t 1: bold \n\t 2: italic \n\t 3: underline \n\t 4: clear");
                    int font = (int)Convert.ToSingle(Console.ReadLine());

                    switch (font)
                    {
                        case 1:
                            Style c = Style.bold;
                            if (font == (int)c)
                            {
                                Console.WriteLine("Параметры подписи: {0}", c);
                            }
                            break;

                        case 2:
                            c = Style.italic;
                            if (font == (int)c)
                            {
                                Console.WriteLine("Параметры подписи: {0}", c);
                            }
                            break;

                        case 3:
                            c = Style.underline;
                            if (font == (int)c)
                            {
                                Console.WriteLine("Параметры подписи: {0}", c);
                            }
                            break;

                        case 4:
                            Console.Clear();
                            break;
                    }
                }
                while (Console.ReadKey().Key != ConsoleKey.Escape);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Thread.Sleep(3000);
         }
      }
}
