namespace Task_03
{
    using System;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Написать программу, которая определяет 
        /// сумму неотрицательных элементов в одномерном массиве. 
        /// Число элементов в массиве и их тип определяются разработчиком. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            int n;
            Console.Write("Введите число элементов в массиве \n");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= 0)
                {
                    sum += arr[i];
                }
            }

            foreach (int x in arr)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();
            Console.Write("Сумма неотрицательных элементов в массиве \n sum = {0} ", sum);
            Console.ReadKey();
        }
    }
}
