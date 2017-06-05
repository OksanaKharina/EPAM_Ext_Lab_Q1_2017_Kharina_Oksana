namespace Task_01
{
    using System;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Написать программу, которая определяет среднюю длину слова 
        /// во введенной текстовой строке. Учесть, что символы пунктуации 
        /// на длину слов влиять не должны. Регулярные выражения не использовать. 
        /// И не пытайтесь прописать все ручками. Используйте 
        /// стандартные методы класса String. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            str = str + ' '; // прибавили в конец пробел, чтобы не потерять последнее слово
            int aver = 0;
            int symbol = 0;
            int sum = 0;

            char[] length = str.ToCharArray(); // массив строки

            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsWhiteSpace(length[i]))
                {
                    sum += 1; 
                }
               else if (char.IsLetter(length[i]) || char.IsDigit(length[i])) // будем считать, что слово может состоять из чисел или содержать число
                {
                    symbol += 1;
                }
            }

            aver = symbol / sum;
            Console.WriteLine("Количество слов = {0} среднее значение = {1} количество букв = {2}", sum, aver, symbol);
            Console.ReadKey();
        }
    }
}
