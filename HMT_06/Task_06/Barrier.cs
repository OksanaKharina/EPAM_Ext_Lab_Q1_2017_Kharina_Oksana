using System;

namespace Task_06
{
    public class Barrier
    {
        public string name;
        public int cellBar; //клетка - местонахождение на поле
        public string Name
        {
            get
            {
                return name;
            }
        }
        public Barrier()
        {
            name = "Barrier";
        }
        public Barrier(string name)
        {
            this.name = name;
        }
        public Barrier(string name, int cellBar)
        {
            this.name = name;
            this.cellBar = cellBar;
        }
        public void Passport()
        {
            Console.WriteLine("Barrier {0} \t cell = {1}", name, cellBar);
        }
        //создаем барьер и позиции в клетках на поле
        public Array arrBarrier()
        {
            Random rnd = new Random();
            int k = 6; //количество монстров
            Barrier[] GroupB = new Barrier[k];
            string[] s = { "камень", "дерево", "река", "гора", "дом", "мертвый монстр" };
            for (int i = 0; i < k; i++)
            {
                cellBar = rnd.Next(1, 100);
                name = s[i];
                GroupB[i] = new Barrier(name, cellBar);
                Passport();
            }
            return GroupB;
        }
    }
}
