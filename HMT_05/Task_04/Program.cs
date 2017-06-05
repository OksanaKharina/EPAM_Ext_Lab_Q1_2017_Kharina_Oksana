using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    /// <summary>
    /// Написать свой собственный класс MyString, 
    /// описывающий строку как массив символов. 
    /// Перегрузить для этого класса типовые операции.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            MyString s = new MyString();
            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");
            do
            {
                try
                {
                    Console.WriteLine("\n Введите строку: \n str1 = ");
                    s.str1 = Convert.ToString(Console.ReadLine());
                    Console.WriteLine(" str2 = ");
                    s.str2 = Convert.ToString(Console.ReadLine());
                    //1
                    Console.WriteLine("Сложение:\t{0}", s.Add());
                    //2
                    Console.WriteLine("Длина:\n\t 1 строки = {0}\n\t 2 строки = {1}", s.lenght(s.str1), s.lenght(s.str2));
                    //3
                    Console.WriteLine("Сравнение:\t{0}", s.Comparison());
                    //4
                    Console.WriteLine("Разбиение строки на слова:");
                    Console.Write("\t{0}", s.Split());
                    //5
                    Console.WriteLine(s.Concat());
                    //6
                    Console.Write("\nДля поиска в строке введите слово \n");
                    string g = Convert.ToString(Console.ReadLine());
                    s.Search(g);
                    //7
                    s.SearchS(g);
                    //8
                    Console.WriteLine("\nДля извлечения определенного количества символов с определенной позиции введите: \n позицию k количество символов l используя клавишу Enter");
                    int k = Convert.ToInt16(Console.ReadLine());
                    int l = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(s.Retrieval(k, l));
                    //9
                    Console.WriteLine("\nУдаление фрагментов и вставка строк в строки");
                    s.Modification(k, l);
                    //10
                    Console.WriteLine("\nСмена регистра первой строки: \n\tверхний регистр {0}\n\tнижний регистр {1}", s.ChangeLower(), s.ChangeUp());
                    Console.WriteLine("\n\t The End. ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
