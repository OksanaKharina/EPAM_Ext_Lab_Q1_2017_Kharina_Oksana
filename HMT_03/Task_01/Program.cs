namespace Task_01
{
    using System;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Написать программу, которая генерирует случайным образом элементы массива 
        /// (число элементов в массиве и их тип определяются разработчиком), 
        /// определяет для него максимальное и минимальное значения, сортирует массив 
        /// и выводит полученный результат на экран.  Примечание: LINQ запросы и 
        /// готовые функции языка (Sort, Max и т.д.) использовать в данном задании запрещается.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)//todo pn не увидел отсортированного массива
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.CursorVisible = false;
            int n;
            Console.Write("Введите число элементов массива: n = ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(100);
                Console.Write(arr[i] + " ");
            }

            int max = arr[0];
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }

                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int sor = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = sor;
                }
            }

            Console.Write("\n max = {0}, min = {1} \n", max, min);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("arr[{0}] = {1} \n", i, arr[i]);
            }

            Console.ReadKey();
        }
    }
}
