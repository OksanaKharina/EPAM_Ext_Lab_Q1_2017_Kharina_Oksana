using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    /// <summary>
    /// На основе класса User (см. задание 3 из предыдущей темы), 
    /// создать класс Employee, описывающий сотрудника фирмы. 
    /// В дополнение к полям пользователя добавить поля 
    /// «стаж работы» и «должность». Обеспечить нахождение 
    /// класса в заведомо корректном состоянии.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;
            string date;
            string dateE;
            DateTime dateOfBirth = new DateTime();
            DateTime dateWork = new DateTime();

            Employee u = new Employee();

            Console.WriteLine("Для выхода нажмите Escape; для продолжения - любую клавишу");


            do
            {
                try
                {
                    Console.WriteLine("Введите пользователя: \n\tфамилия, \n\tимя, \n\tотчество, \n\tдолжность, \n\tдату рождения (dd/mm/yyyy), \n\tдату поступления на работу (dd/mm/yyyy)");
                    u.surname = (Convert.ToString(Console.ReadLine()));
                    u.name = Convert.ToString(Console.ReadLine());
                    u.patronymic = Convert.ToString(Console.ReadLine());
                    u.Post = Convert.ToString(Console.ReadLine());

                    date = Convert.ToString(Console.ReadLine());
                    DateTime.TryParse(date, out dateOfBirth);
                    u.dateOfBirgth = dateOfBirth;
                    u.Age = u.age(dateOfBirth);

                    dateE = Convert.ToString(Console.ReadLine());
                    DateTime.TryParse(dateE, out dateWork);
                    u.dateWork = dateWork;
                    u.workExperience = u.workExp(dateWork);

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
