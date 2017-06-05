namespace Task_02
{
    using System;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Написать программу, которая заменяет все положительные элементы 
        /// в трёхмерном массиве на нули. Число элементов в массиве 
        /// и их тип определяются разработчиком.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            int n;
            Console.Write("Введите число элементов в трехмерном массиве \n");
            n = int.Parse(Console.ReadLine());
            int[,,] arr = new int[n, n, n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; j < n; j++)
                    {
                        arr[i, j, k] = r.Next(-100, 100);
                        if (arr[i, j, k] < 0)
                        {
                            arr[i, j, k] = 0;
                        }

                        Console.WriteLine("arr[{0}, {1}, {2}] = {3} \n", i, j, k, arr[i, j, k]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
