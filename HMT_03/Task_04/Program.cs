namespace Task_04
{
    using System;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Элемент двумерного массива считается стоящим на чётной позиции, 
        /// если сумма номеров его позиций по обеим размерностям является 
        /// чётным числом (например, [1,1] – чётная позиция, а [1,2] - нет).  
        /// Определить сумму элементов массива, стоящих на чётных позициях. 
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
            int[,] arr = new int[n, n];

            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = r.Next(-100, 100);
                    Console.Write("{0} \t", arr[i, j]);
                }

                Console.WriteLine();
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) % 2 != 0)
                    {
                        continue;
                    }

                    sum += arr[i, j];
                }
            }

            Console.WriteLine();
            Console.Write("Сумма элементов в массиве, стоящих на четных позициях \n sum = {0} ", sum);
            Console.ReadKey();
        }
    }
}
