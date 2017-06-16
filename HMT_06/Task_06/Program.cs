using System;

namespace Task_06
{
    /// <summary>
    /// Создайте иерархию классов и пропишите ключевые методы 
    /// для компьютерной игры (без реализации функционала). 
    /// Суть игры:  
    /// 1. Игрок может передвигаться по прямоугольному полю размером Width на Height.   
    /// 2. На поле располагаются бонусы (яблоко, вишня и т.д.), 
    ///     которые игрок может подобрать для поднятия каких-либо характеристик.
    /// 3. За игроком охотятся монстры (волки, медведи и т.д.), 
    ///     которые могут передвигаться по карте по какому-либо алгоритму.  
    /// 4. На поле располагаются препятствия разных типов (камни, деревья и т.д.), 
    ///     которые игрок и монстры должны обходить.  
    /// Цель игры – собрать все бонусы и не быть «съеденным» монстрами. 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.CursorVisible = false;

            Console.Write("Введите свое имя: ");
            Player P = new Player();
            P.name = Console.ReadLine();
            P.Passport();

            Console.WriteLine();

            //индексация клеток на поле
            Field F = new Field();
            F.arrField();

            Console.WriteLine();

            //Monster = index 
            Monster M = new Monster();
            M.arrMonster();

            Console.WriteLine();

            //Barrier = index
            Barrier B = new Barrier();
            B.arrBarrier();

            Console.WriteLine();

            //Bonuses = index
            Bonuses Bon = new Bonuses();
            Bon.arrBonuses();

            Console.WriteLine();

            //увеличиваем здоровье игрока           
            for (int i = 0; i < 7; i++)
            {
                P.pos = i;
                if (P.pos != Bon.tmp[i])
                {
                    Bon.left++;
                    P.health -= Bon.left;
                }            
            }
            P.Passport();

            P.Draw();
            Console.ReadKey();
        }
    }
}
