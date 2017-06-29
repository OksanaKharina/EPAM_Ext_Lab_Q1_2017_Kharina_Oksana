using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    public class Office : Person
    {
        delegate void Message(string name);

        public static void OfficeGr()
        {
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
        }
    }
}
