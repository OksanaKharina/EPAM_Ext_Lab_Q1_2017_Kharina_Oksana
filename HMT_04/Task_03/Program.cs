namespace Task_03
{
    using System;
    using System.Diagnostics;
    using System.Text;

    class Program
    {
        /// <summary>
        /// Проведите сравнительный анализ скорости работы классов String и StringBuilder для операции сложения строк:
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            var sw = new Stopwatch();

            sw.Start();

            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            Console.WriteLine("class String");
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            Console.WriteLine(sw.ElapsedTicks);
            sw.Restart();

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }

            sw.Stop();
            Console.WriteLine("class StringBuilder");
            Console.WriteLine(sw.ElapsedMilliseconds); 
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            Console.WriteLine(sw.ElapsedTicks);
            Console.ReadKey();
        }
    }
}
