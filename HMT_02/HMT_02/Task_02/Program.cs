using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    /// <summary>
    /// Написать программу, которая запрашивает с клавиатуры чило N 
    /// и выводит на экран изображение - прямоугольник, состоящее из N строк
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.CursorVisible = false;
            Console.Write("N = ");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            char[,] arr = new char[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    arr[i, j] = '*';
                    Console.Write(arr[i, j]);

                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
