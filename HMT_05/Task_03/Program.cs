using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    /// <summary>
    /// Написать класс User, описывающий человека 
    /// (Фамилия, Имя, Отчество, Дата рождения, Возраст). 
    /// Написать программу, демонстрирующую использование этого класса. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;
            string date;
            DateTime dateOfBirth = new DateTime();

            User u = new User();

            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");


            do
            {
                try
                {
                    Console.WriteLine("Введите пользователя: фамилия, имя, отчество, дата рождения (dd/mm/yyyy)");
                    u.surname = (Convert.ToString(Console.ReadLine()));
                    u.name = Convert.ToString(Console.ReadLine());
                    u.patronymic = Convert.ToString(Console.ReadLine());

                    date = Convert.ToString(Console.ReadLine());
                    DateTime.TryParse(date, out dateOfBirth);
                    u.dateOfBirgth = dateOfBirth;
                    u.Age = u.age(dateOfBirth);
                    u.Display();
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