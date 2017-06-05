using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task_04
{
    public class MyString
    {
        public string str1 { get; set; }
        public string str2 { get; set; }
        ///<summary>сложение</summary>
        public string Add()
        {
            return str1 + " " + str2;
        }
        ///<summary>длина</summary>
        public int lenght(string str1)
        {
            return str1.Length;
        }
        ///<summary>сравнение</summary>
        public string Comparison()
        {
            if (str1.Length > str2.Length)
            {
                return "строка 1 > строки 2";
            }
            else if (str1.Length < str2.Length)
            {
                return "строка 1 < строки 2";
            }
            else
            {
                return "строка 1 = строки 2";
            }
        }
        ///<summary>Разбиение строки на слова</summary>
        public string Split()
        {
            string pattern = "[- ,./+= !@$%^&*()?|]+";
            Regex r = new Regex(pattern);
            List<string> st = new List<string>(r.Split(str1));
            foreach (string s in st)
            {
                Console.WriteLine(s);
            }
            return "";
        }
        ///<summary>Конкатенация строк</summary>
        public string Concat()
        {
            return String.Concat("\n" + "one, two ", "three, four");
        }
        ///<summary>Поиск слова в строке (первое вхождение)</summary>
        private string s;
        public string Search(string s)
        {
            if (str1.IndexOf(s) != -1)
            {
                Console.WriteLine("\nПервое вхождение слова {0} найдено в строке, оно на {1} позиции", s, str1.IndexOf(s));
            }
            else Console.WriteLine("\nтакого слова нет в строке");
            return "";
        }
        ///<summary>Посик слова в строке (второе вхождение)</summary>
        public string SearchS(string s)
        {
            if (str1.LastIndexOf(s) != -1)
            {
                Console.WriteLine("\nПоследнее вхождение слова {0} найдено в строке, оно на {1} позиции", s, str1.LastIndexOf(s));
            }
            else Console.WriteLine("\nтакого слова нет в строке");
            return "";
        }
        ///<summary>Извлечение с определенной позиции определенного количества знаков</summary>
        public string Retrieval(int k, int l)
        {
            return str1.Substring(k, l);
        }
        ///<summary>Удаление фрагментов и вставка строк в строки</summary>
        public string Modification(int k, int l)
        {
            Console.WriteLine(str1.Remove(l,k));
            Console.WriteLine(str1.Insert(k,"*"));
            return "";
        }
        ///<summary>Смена регистра</summary>
        public string ChangeLower()
        {
            return str1.ToUpper();
        }
        public string ChangeUp()
        {
            return str1.ToLower();
        }
    }
}
