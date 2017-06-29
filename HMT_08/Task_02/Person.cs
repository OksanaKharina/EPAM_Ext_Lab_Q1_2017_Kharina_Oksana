using System;

namespace Task_02
{
    public class Person
    {
        public string Name { get; set; }
        public void ComeToWork(string workPerson)
        {
            Console.WriteLine("\n" + "[На работу пришёл {0}]", workPerson, Name);
        }
        public void MGreet(string anotherPerson)
        {
            Console.WriteLine("'Доброе утро, {0}!', - сказал {1}.", anotherPerson, Name);
        }
        public void Greet(string anotherPerson)
        {
            Console.WriteLine("'Добрый день, {0}!', - сказал {1}.", anotherPerson, Name);
        }
        public void EGreet(string anotherPerson)
        {
            Console.WriteLine("'Добрый вечер, {0}!', - сказал {1}.", anotherPerson, Name);
        }
        public void LeaveTheJob(string jobPerson)
        {
            Console.WriteLine("\n" + "[{0} ушёл домой]", jobPerson, Name);
        }
        public void Bye(string partPerson)
        {
            Console.WriteLine("'До свидания, {0}!', - сказал {1}.", partPerson, Name);
        }
    }
}
