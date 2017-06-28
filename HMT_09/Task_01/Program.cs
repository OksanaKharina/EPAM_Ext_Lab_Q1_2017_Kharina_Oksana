namespace Task_01
{
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// Напишите расширяющий метод,
    /// который определяет сумму элементов массива.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");
            do
            {

                try
                {
                    Console.WriteLine("\nВведите размерность массива");
                    int n = Convert.ToInt16(Console.ReadLine());
                    if (n > 0)
                    {
                        int[] arr = new int[n];
                        Console.WriteLine("\nВведите элементы в массив");
                        string str = Console.ReadLine();

                        string[] massiv = str.Split(' ');

                        for (int i = 0; i < massiv.Length; i++)
                        {
                            arr[i] = Convert.ToInt32(massiv[i]);
                        }

                        for (int i = 0; i < arr.Length; i++)
                        {
                            Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
                        }

                        int sum = arr.Sum();

                        Console.WriteLine("\nСумма в массиве равна {0}", sum);
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели некорректные данные, попробуйте еще раз");
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.ReadKey();
        }
    }
}
