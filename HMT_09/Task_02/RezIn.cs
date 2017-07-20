namespace Task_02
{
    using System;

    public static class RezIn
    {
        public static string Rez(this string str)
        {
            try
            {
                double rez = Convert.ToDouble(str);//todo pn а если разделителем целой и дробной частей будет ".". Нужно определять ещё и культуру.
                if (rez % 1 == 0 && rez > 0)
                {
                    return "Строка является целым положительным числом";
                }
                else
                {
                    return "Строка является отрицательным числом"; //todo pn некорректное сообщение (попробуй ввести 3.2)
                }
            }
            catch
            {
                return "Ошибка ввода";
            }
        }
    }
}
