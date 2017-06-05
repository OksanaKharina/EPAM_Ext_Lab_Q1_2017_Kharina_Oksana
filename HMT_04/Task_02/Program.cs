namespace Task_02
{
    using System;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Написать программу, которая удваивает в первой введенной строки
        /// все символы, принадлежащие второй введенной строке. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.Write("Введите первую строку str1: ");
            string str1 = Console.ReadLine();
            Console.Write("Введите слово:");
            string str2 = Console.ReadLine();

            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();

            for (int i = 0; i < str1.Length; i++)
            {
                Console.Write(a[i]);
                for (int j = 0; j < str2.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Console.Write(b[j]);
                        j = str2.Length;
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
