using System.Text;

namespace Task_02
{
    using System;

    /// <summary>
    /// Дано действительное число h.
    /// Выяснить, имеет ли уравнение ax^2+bx+c=0
    /// действительные корни, если а, b, c заданы выражением
    /// Если действительные корни существуют, то найти их.
    /// В противном случае ответом должно служить сообщение,
    /// что действительных корней нет
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            Console.CursorVisible = false;
            string ok = "y";

            while (ok == "y" || ok == "н")
            {
                double a, b, c, d, h, x1, x2, x;

                Console.WriteLine("Найти корни уравнения a*x^2 + b*x + c = 0, зная действительное число h");
                Console.WriteLine("Введите h:");

                h = Convert.ToDouble(Console.ReadLine());

                a = Math.Sqrt((Math.Abs(Math.Sin(8 * h)) + 17) / Math.Pow(1 - (Math.Sin(4 * h) * Math.Cos(Math.Pow(h, 2) + 18)), 2));
                b = 1 - Math.Sqrt(3 / (3 + Math.Abs(Math.Tan(a * Math.Pow(h, 2)) - Math.Sin(a * h))));
                c = (a * Math.Pow(h, 2) * Math.Sin(b * h)) + (b * Math.Pow(h, 3) * Math.Cos(a * h));

                d = Math.Pow(b, 2) - (4 * a * c);

                Console.WriteLine("Коэффициенты квадратного уравнения: \n a = {0}, \n b = {1}, \n c = {2}, \n дикриминант: d = {3}", a, b, c, d);

                x1 = (-b - Math.Sqrt(d)) / 2 / a;
                x2 = (-b + Math.Sqrt(d)) / 2 / a;
                x = (-b) / 2 / a;

                if (d > 0)
                {
                    Console.WriteLine("Дискриминант больше нуля, уравнение имеет два корня \n x1={0} \n x2={1} ", x1, x2);
                }
                else if (d == 0)
                {
                    Console.WriteLine("Дискриминант равен нулю, уравнение имеет один корень \n х ={0} ", x);
                }
                else
                {
                    Console.WriteLine("Дискриминант меньше нуля - корней нет");
                }

                Console.WriteLine("Хотите ввести другое значение h: y(н)/n(т) ?");

                ok = Convert.ToString(Console.ReadLine());

                Console.Clear();
            }
        }
    }
}
