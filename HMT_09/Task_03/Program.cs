namespace Task_03
{
    using System;
    using System.Collections;
    using System.Text;

    /// <summary>
    /// Написать методы поиска элемента в массиве
    /// (например, поиск всех положительных элементов в массиве) в виде:
    /// 1. Метода, реализующего поиск напрямую;
    /// 2. Метода, которому условие поиска передаётся через делегат;
    /// 3. Метода, которому условие поиска передаётся через делегат в виде анонимного метода;
    /// 4. Метода, которому условие поиска передаётся через делегат в виде лямбда-выражения;
    /// 5. LINQ-выражения  Сравнить скорость выполнения вычислений.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;

            ArrayList coll = ListOperation.NewCollection(8);

            ListOperation.WriteList(coll);

            // #1
            Console.WriteLine("\n[ Task 01 ]\n");
            ListOperation.SortDirect(coll);

            // #2
            Console.WriteLine("\n[ Task 02 ]\n");
            DelegateSort delSort = new DelegateSort(ListOperation.SortDel);
            Console.WriteLine(delSort(coll));

            // #3
            Console.WriteLine("\n[ Task 03 ]\n");
            DelegateSort dell = ListOperation.SortVar();//todo pn где анонимный тип?
            ListOperation.WriteList(dell(coll));

            // #4
            Console.WriteLine("\n[ Task 04 ]\n");
            ListOperation.NewLamArr(8);

            // №5
            /*double[] n1 = new double[10];
            for (int i = 0; i< 10; i++)
            {
            sw.Start();*/
            Console.WriteLine("\n[ Task 05 ]\n");
            ListOperation.LinqArr(coll);
            /*sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.WriteLine(sw.Elapsed.TotalMilliseconds);
            Console.WriteLine(sw.ElapsedTicks);

                n1[i] = sw.Elapsed.TotalMilliseconds;
            }
            Array.Sort(n1);
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}\t", n1[i]);
            }
            double k = (n1[4] + n1[5]) / 2;
            Console.WriteLine("Медиана Me = {0}", k);*/

            Console.ReadKey();
        }
    }
}
