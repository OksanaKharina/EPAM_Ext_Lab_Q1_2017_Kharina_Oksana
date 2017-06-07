using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Написать программу, которая запрашивает с клавиатуры число N
/// и выводит на экран изображение - пирамида, состоящее из N строк
/// </summary>
namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.CursorVisible = false;
            Console.Write("N = ");
            string str = Console.ReadLine();
            int n = int.Parse(str);//todo pn упадет здесь, если пользователь введет не число
			int k = n * 2;
            char[,] arr = new char[n, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    arr[i, j] = ' ';
                }
            }

            // left
            for (int i = 0; i < n; i++)
            {
                for (int j = (k / 2) - i; j < n + 1; j++)
                {
                    arr[i, j] = '*';
                }
            }

            // right
            for (int i = 0; i < n; i++)
            {
                for (int j = n + 1; j < (k / 2) + 1 + i; j++)
                {
                    arr[i, j] = '*';
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    Console.Write(arr[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
