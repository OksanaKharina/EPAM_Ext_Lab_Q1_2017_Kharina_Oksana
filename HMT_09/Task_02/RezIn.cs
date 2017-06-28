namespace Task_02
{
    using System;

    public static class RezIn
    {
        public static string Rez(this string str)
        {
            try
            {
                double rez = Convert.ToDouble(str);
                if (rez % 1 == 0 && rez > 0)
                {
                    return "Строка является целым положительным числом";
                }
                else
                {
                    return "Строка является отрицательным числом";
                }
            }
            catch
            {
                return "Ошибка ввода";
            }
        }
    }
}
