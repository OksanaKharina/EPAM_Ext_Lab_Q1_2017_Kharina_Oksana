using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_02
{
    /// <summary>
    /// Задан английский текст. Выделить отдельные слова 
    /// и для каждого посчитать частоту встречаемости. 
    /// Слова, отличающиеся регистром, считать одинаковыми. 
    /// В качестве разделителей считать пробел и точку
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            StreamReader f = new StreamReader(@"C:\Users\Оксана\Desktop\EPAM_Ext_Lab_Q1_2017_Kharina_Oksana\HMT_07\Task_02\text.txt", Encoding.Default);//todo pn ну, у меня на машине такого пути нет... Используй относительные пути.
            string s = f.ReadToEnd();

            char[] separ = {' ', '.', ','};
            List<string> words = new List<string>(s.Split(separ));
            Dictionary<string, int> map = new Dictionary<string, int>();

            foreach (string w in words)
            {
                if (map.ContainsKey(w))
                {
                    map[w]++;
                }
                else
                {
                    map[w] = 1;
                }
            }

            foreach (string w in map.Keys)
                Console.WriteLine("{0} \t {1}", w, map[w]);

            f.Close();
            Console.ReadKey();
        }
    }
}
