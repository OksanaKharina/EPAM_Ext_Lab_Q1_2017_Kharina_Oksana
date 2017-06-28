using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    /// <summary>
    /// Написать программу, выполняющую сортировку 
    /// массива строк по возрастанию длины. 
    /// Если строки состоят из равного числа символов, 
    /// их следует отсортировать по алфавиту. 
    /// Реализовать метод сравнения строк отдельным методом, 
    /// передаваемым в сортировку через делегат.
    /// </summary>
    class Program
    {
        delegate string DelegateSort(string str);

        static string MethodSrav(string str)
        {
            string[] massiv = str.Split(' ');

            //сортировка по длине слов
            for (int i = 0; i < massiv.Length - 1; i++)
            {
                for (int j = i + 1; j < massiv.Length; j++)
                {
                    if (massiv[j].Length < massiv[i].Length)
                    {
                        string s = massiv[i];
                        massiv[i] = massiv[j];
                        massiv[j] = s;
                    }
                }
            }
            str = "";
            for (int i = 0; i < massiv.Length; i++)
                str = str + massiv[i] + " ";
            return str;
        }

        static string MethodSor(string str)
        {
            str = MethodSrav(str);
            string[] massiv = str.Split(' ');

            //сортировка на условие одинаковой длины слова
            for (int i = 0; i < massiv.Length; i++)
            {
                for (int j = 0; j < massiv.Length - 1; j++)
                {
                   if (massiv[j].Length == massiv[j + 1].Length)
                    {
                        if (SortStringMassiv(massiv[j], massiv[j + 1]))
                        {
                            string s = massiv[j];
                            massiv[j] = massiv[j + 1];
                            massiv[j + 1] = s;
                        }
                    }
                }
            }

            str = "";
            for (int i = 0; i < massiv.Length; i++)
                str = str + massiv[i] + " ";

            return str;
        }
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            DelegateSort delsor = new DelegateSort(MethodSrav);

            Console.WriteLine("Введите предложение: \n");
            string str = Console.ReadLine();
            string rezult = delsor.Invoke(str);

            delsor = new DelegateSort(MethodSor);
            delsor = MethodSor;
            rezult = delsor.Invoke(str);

            Console.WriteLine("\n Ваш массив слов после сортировки \n" + rezult);

            Console.ReadKey();
        }
        //реализация сортировки
        protected static bool SortStringMassiv(string s1, string s2)
        {
            for (int i = 0; i < (s1.Length > s2.Length ? s2.Length : s1.Length); i++)
            {
                if (s1.ToCharArray()[i] < s2.ToCharArray()[i]) return false;
                if (s1.ToCharArray()[i] > s2.ToCharArray()[i]) return true;
            }
            return false;
        }
    }
}
