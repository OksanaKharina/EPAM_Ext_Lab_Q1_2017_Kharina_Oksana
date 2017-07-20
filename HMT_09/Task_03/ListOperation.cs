namespace Task_03
{
    using System;
    using System.Collections;
    using System.Linq;

    public delegate ArrayList DelegateSort(ArrayList arr);

    public delegate bool DelSort(int x);

    public static class ListOperation
    {
        public static ArrayList NewCollection(int i)
        {
            Random ran = new Random();
            ArrayList arr = new ArrayList();

            for (int j = 0; j < i; j++)
            {
                arr.Add(ran.Next(-50, 50));
            }

            return arr;
        }

        public static void WriteList(ArrayList arr)
        {
            foreach (int a in arr)
            {
                Console.Write("{0}\t", a);
            }

            Console.WriteLine("\n");
        }

        // sorting directly
        public static void SortDirect(ArrayList arr)
        {
            Console.WriteLine("\n[ Поиск на прямую ]\n");
            foreach (int a in arr)
            {
                if (a > 0)
                {
                    Console.Write("{0}\t", a);
                }
            }

            Console.WriteLine("\n");
        }

        // sorting through delegates
        public static ArrayList SortDel(ArrayList arr)//todo pn условие передается через делегат, а не весь метод поиска
        {
            Console.WriteLine("\n[ Условие поиска черезделегат ]\n");
            foreach (int a in arr)
            {
                if (a > 0)
                {
                    Console.Write("{0}\t", a);
                }
            }

            Console.WriteLine("\n");
            return arr;
        }

        // sorting through delegates (anonymous method)
        public static DelegateSort SortVar()
        {
            Console.WriteLine("\n[ С использованием делегата в виде анонимного метода ]\n");
            DelegateSort del = delegate (ArrayList arr)
            {
                foreach (int a in arr)
                {
                    if (a > 0)
                    {
                        Console.Write("{0}\t", a);
                    }
                }

                Console.WriteLine("\n");
                return arr; // возвращает повторно массив, запрашивает return
                // может есть другой способ реализации? //todo pn конечно есть. нужно передавать само условие (а > 0) через делегат
            };
            return del;
        }

        // sorting through delegates (lambda expressions)
        public static void NewLamArr(int n)
        {
            Console.WriteLine("\n[ Новый массив (так как ArrayList не разрешает использовть лямбда-выражения) ]\n");
            int[] num = new int[n];
            Random ran = new Random();
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = ran.Next(-50, 50);
                Console.Write("{0}\t", num[i]);
            }

            Console.WriteLine("\n");
            DelSort d = value => value > 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (d(num[i]) == true)
                {
                    Console.Write("{0}\t", num[i]);
                }
            }
        }

        // LINQ - expressesion
        public static void LinqArr(ArrayList arr)
        {
            Console.WriteLine("\n\n[ Linq-выражения с использованием ArrayList ]\n");
            var lst = from int item in arr
                      where item > 0
                      select item;
            foreach (int x in lst)
            {
                Console.Write("{0}\t", x.ToString());
            }
        }
    }
}
