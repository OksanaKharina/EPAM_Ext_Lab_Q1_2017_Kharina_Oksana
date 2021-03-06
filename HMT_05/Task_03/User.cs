﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class User
    {
        private string s;
        public string surname
        {
            get { return s; }
            set
            {
                if (value == null)
                {
                    throw new Exception("Error");
                }
                else
                {
                    s = value;
                }
            }
        }
        public string name { get; set; }
        public string patronymic { get; set; }
        public DateTime dateOfBirgth { get; set; }
        public int Age { get; set; }
        public User()
        {
        }
        public int age(DateTime dateOfBirgth)
        {
            int ageYears = DateTime.Now.Year - dateOfBirgth.Year;
            if (DateTime.Now.Month < dateOfBirgth.Month || (DateTime.Now.Month == dateOfBirgth.Month && DateTime.Now.Day < dateOfBirgth.Day))
            {
                ageYears--;
            }
            return ageYears;
        }
        public User (string surname, string name, string patronomic, DateTime dateOfBirth, int Age)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.dateOfBirgth = dateOfBirgth;
            this.Age = age(dateOfBirgth);
        }
        public void Display()
        {
            Console.WriteLine("Фамилия: {0}\nИмя: {1}\nОтчество: {2}\nДата рождения: {3}\nВозраст: {4}", surname, name, patronymic, dateOfBirgth, Age);
        }
    }
}
