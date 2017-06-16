using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Employee : User
    {
        public string Post { get; set; }
        public DateTime dateWork { get; set; }
        public string workExperience { get; set; }
        public Employee()
        {
        }
        public string workExp(DateTime dateWork)
        {
            int ageMonth = DateTime.Now.Month - dateWork.Month;
            int ageYears = DateTime.Now.Year - dateWork.Year;
            if (DateTime.Now.Month < dateWork.Month || (DateTime.Now.Month == dateWork.Month && DateTime.Now.Day < dateWork.Day))
            {
                ageMonth--;
                ageYears--;
            }
            string work = ageMonth + " месяц(..) " + ageYears + " лет(год)";
            return work;
        }
        public Employee(string surname, string name, string patronomic, DateTime dateOfBirth, int Age, string Post, string workExperience) : base (surname, name, patronomic, dateOfBirth, Age)
        {
            this.Post = Post;
            this.workExperience = workExperience;
        }
        public void Display()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДолжность: {3}\nДата рождения: {4}\nВозраст: {5}\nСтаж работы:{6}", surname, name, patronymic, Post, dateOfBirgth, Age, workExperience);
        }
    }
}
