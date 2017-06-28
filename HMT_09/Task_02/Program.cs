namespace Task_02
{
    using System;
    using System.Text;

     /// <summary>
     /// Напишите расширяющий метод, который определяет,
     /// является ли строка положительным целым числом.
     /// Методы Parse и TryParse не использовать
     /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            Console.WriteLine("Введите число");
            string str = Console.ReadLine();
            string ok = str.Rez();
            Console.WriteLine(ok);
            Console.ReadKey();
        }
    }
}
