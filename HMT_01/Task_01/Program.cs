using System.Text;

namespace Task_01
{
    using System;

    /// <summary>
    /// Написать консольное приложение, которое проверяет принадлежность точки
    /// к заштрихованной области.
    /// Пользователь вводит координаты точки (x;y) и выбирает букву графика (а-к)
    /// В консоли должно высветиться сообщение: "Точка [(x;y)] принадлежит фигуре [г]"
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
	        Console.InputEncoding = Encoding.Unicode;//todo pn без явного задания кодировки будет использована кодировка по умолчанию. Машина, на которой я проверяю настроена на английскую культуру, поэтому кириллические символы отображаются в ней как знаки вопроса. Следует учитывать такое специфичное поведение консоли в следующих заданиях :)/
	        Console.OutputEncoding = Encoding.Unicode;

			float x, y;
            Console.CursorVisible = false; // чтобы не было мигающего курсора
            string str, ok;
            ok = "y";
            while (ok == "y" || ok == "н")
            {
                Console.WriteLine("Введите координаты точки x, y");
                Console.WriteLine("x = ");
                x = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("y = ");
                y = Convert.ToSingle(Console.ReadLine());
                while (ok == "y" || ok == "н")
                {
                    Console.WriteLine("Выберите график, для которого Вы хотите определить принадлежность точки: \n а, б, в, г, д, е, ж, з, и, к \n");
                    str = Console.ReadLine();
                    switch (str)
                    {
                        // окружность 1
                        case "а":
                            MathOperation newACircle = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newACircle.ACircleOne(), str);
                            ok = string.Empty;
                            break;

                        // окружность 2
                        case "б":
                            MathOperation newCircle = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newCircle.BCircleTwo(), str);
                            ok = string.Empty;
                            break;

                        // квадрат
                        case "в":
                            Console.Write("Точка ({0}; {1}) ", x, y);
                            Console.WriteLine(x <= 1 && x >= -1 && y <= 1 && y >= -1 ? " принадлежит " : " не принадлежит ");
                            Console.Write("графику {0} \n", str);
                            ok = string.Empty;
                            break;

                        // правильный ромб
                        case "г":
                            Console.Write("Точка ({0};{1}) ", x, y);
                            Console.WriteLine((Math.Abs(x + y) <= 1 && Math.Abs(x - y) <= 1) ? " принадлежит " : " не принадлежит ");
                            Console.Write("графику {0} \n", str);
                            ok = string.Empty;
                            break;

                        // ромб
                        case "д":
                            MathOperation newRhomb = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newRhomb.Rhomb(), str);
                            ok = string.Empty;
                            break;

                        // треугольник и полуокружность
                        case "е":
                            MathOperation newTriCir = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newTriCir.TriCir(), str);
                            ok = string.Empty;
                            break;

                        // треугольник
                        case "ж":
                            MathOperation newTriangle = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newTriangle.Triangle(), str);
                            ok = string.Empty;
                            break;

                        // 2 треугольника и прямоугольник. Рассмотрена модуль функции
                        case "з":
                            Console.Write("Точка ({0};{1}) ", x, y);
                            Console.Write(x >= -1 && x <= 1 && y >= -2 && y <= 1 && y <= Math.Abs(x) ? " принадлежит " : " не принадлежит ");
                            Console.Write("графику {0} \n", str);
                            ok = string.Empty;
                            break;

                        // многоугольник
                        case "и": //todo pn говорит, что точка (-2; -1) не принадлежит фигуре
                            MathOperation newPolygon = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newPolygon.Polygon(), str);
                            ok = string.Empty;
                            break;

                        // бесконечная плоскость
                        case "к":
                            MathOperation newInfPlane = new MathOperation();
                            Console.Write("Точка ({0}; {1}) {2} {3} \n", x, y, newInfPlane.InfPlane(), str);
                            ok = string.Empty;
                            break;

                        default:
                            Console.WriteLine("Ошибка! Необходимо вводить: а, б, в, г, д, е, ж, з, и или к. \n");
                            ok = "y";
                            break;
                    }
                }

                Console.WriteLine("Хотите продолжить: y?");

                ok = Convert.ToString(Console.ReadLine());
            }
        }
    }
}
