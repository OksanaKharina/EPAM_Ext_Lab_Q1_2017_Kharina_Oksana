using System;
using System.Text;

namespace Task_02
{
    /// <summary>
    /// Написать программу, описывающую небольшой офис, 
    /// в котором работают сотрудники – объекты класса Person, 
    /// обладающие полем имя (Name). Каждый из сотрудников 
    /// содержит пару методов: приветствие сотрудника, 
    /// пришедшего на работу (принимает в качестве аргументов 
    /// объект сотрудника и время его прихода)  
    /// и прощание с ним (принимает только объект сотрудника). 
    /// В зависимости от времени суток, приветствие 
    /// может быть различным: до 12 часов – «Доброе утро», 
    /// с 12 до 17 – «Добрый день», 
    /// начиная с 17 часов – «Добрый вечер». 
    /// Каждый раз при входе очередного сотрудника в офис, 
    /// все пришедшие ранее его приветствуют. 
    /// При уходе сотрудника домой с ним также прощаются все присутствующие. 
    /// Вызов процедуры приветствия/прощания производить 
    /// через групповые делегаты. Факт прихода и ухода сотрудника отслеживается 
    /// через генерируемые им события. Событие прихода описывается делегатом, 
    /// передающим в числе параметров наследника EventArgs, явно содержащего
    /// поле с временем прихода. Продемонстрировать работу офиса 
    /// при последовательном приходе и уходе сотрудников.
    /// </summary>
    class Program
    {
        delegate void Message(string name);
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            Person john = new Person { Name = "Джон" };
            Person bill = new Person { Name = "Билл" };
            Person hugo = new Person { Name = "Хьюго" };

                        //ПРИХОД НА РАБОТУ
            Message workJohn = new Message(john.ComeToWork);
            Message workBill = new Message(bill.ComeToWork);
            Message workHugo = new Message(hugo.ComeToWork);

                       //приветствие
            Message greetByJohn = new Message(john.Greet);
            Message greetByBill = new Message(bill.Greet);
            Message greetByHugo = new Message(hugo.Greet);

            Message greetByUs = (Message)Delegate.Combine(
                greetByJohn);

            workJohn?.Invoke("Джон");

            workJohn?.Invoke("Билл");
            greetByUs?.Invoke("Билл");

            workJohn?.Invoke("Хьюго");
            greetByUs += bill.Greet;
            greetByUs?.Invoke("Хьюго");
            greetByUs += hugo.Greet;

                        //уйти с работы
            Message jobJohn = new Message(john.LeaveTheJob);
            Message jobBill = new Message(bill.LeaveTheJob);
            Message jobHugo = new Message(hugo.LeaveTheJob);
                        //прощание
            Message byeByJohn = new Message(john.Bye);
            Message byeByBill = new Message(bill.Bye);
            Message byeByHugo = new Message(hugo.Bye);

            Message byeByUs = (Message)Delegate.Combine(
                byeByJohn,
                byeByBill,
                byeByHugo);

            jobJohn?.Invoke("Джон");
            byeByUs -= john.Bye;
            byeByUs?.Invoke("Джон");

            jobBill?.Invoke("Билл");
            byeByUs -= bill.Bye;
            byeByUs?.Invoke("Билл");

            jobHugo?.Invoke("Хьюго");

            Console.ReadKey();
        }
    }
}
