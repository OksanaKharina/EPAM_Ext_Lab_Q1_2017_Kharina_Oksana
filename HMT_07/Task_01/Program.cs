using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    /// <summary>
    /// В кругу стоят N человек, пронумерованных от 1 до N. 
    /// При ведении счета по кругу вычёркивается каждый второй 
    /// человек, пока не останется один. 
    /// Составить программу, моделирующую процесс
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int i in numbers)
            {
                Console.Write(" " + i);
            }

            int j = 0;
            while (numbers.Count != 1)
            {
                Console.WriteLine(" n = " + numbers.Count);
                for (j = 0; j < numbers.Count; j++)
                {

                    if (j % 2 != 0)
                    {
                        numbers.RemoveAt(j);
                    }

                }
                Console.WriteLine();
                foreach (int i in numbers)
                {
                    Console.Write(" " + i);
                }
                double k = numbers.Count / 2;
                j = (int)Math.Ceiling(k);
            }
            Console.ReadLine();
        }
    }
}
