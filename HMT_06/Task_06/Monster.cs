using System;

namespace Task_06
{
    public class Monster//todo pn а монстры статичны и не хотят съесть героя? так не интересно...
    {
        public string name;
        public int health; //здоровье
        public int cell; //клетка - местонахождение на поле
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value > 0) health = value;
                else health = 0;
            }
        }
        public Monster()
        {
            name = "Monster";
            health = 10;
        }
        public Monster(string name)
        {
            this.name = name;
        }
        public Monster(string name, int health, int cell)
        {
            this.name = name;
            this.health = health;
            this.cell = cell;
        }
        public void Passport()
        {
            Console.WriteLine("Monster {0} \t health = {1} cell = {2}", name, health, cell);
        }
        //создаем монстров и позиции в клетках на поле
        public Array arrMonster()
        {
            Random rnd = new Random();
            int k = 5; //количество монстров
            Monster[] GroupM = new Monster[k];
            string[] s = { "заяц", "волк", "медведь", "лиса", "акула" };//todo pn лучше вынести в отдельный enum
			for (int i = 0; i < k; i++)
            {
                cell = rnd.Next(1, 100);
                health = rnd.Next(1, 10);
               name = s[i];
                GroupM[i] = new Monster(name, health, cell);
                Passport();
            }
         return GroupM;            
          }
    }
} 
