using System;

namespace Task_06
{
    interface IAction
    {
        void Draw(); // появление в игре
        int Attack(int a); //атаковать
        void Die(); //смерть
        int Power { get; } //энергия - здоровье
    }
    public class Player : IAction
    {
        public string name { get; set; }
        public int pos; //позиция на поле
        public int health = 100; //здоровье
        public int ammo = 100; //патроны
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
        public int Ammo
        {
            get
            {
                return ammo;
            }
            set
            {
                if (value > 0) ammo = value;
                else ammo = 0;
            }
        }
        public Player()
        {
            name = "Gamer";
            health = 100;
            ammo = 100;
        }
        public Player(string name)
        {
            this.name = name;
        }
        public Player(string name, int health, int ammo)
        {
            this.name = name;
            this.health = health;
            this.ammo = ammo;
        }

        public void Draw()
        {
            Console.WriteLine("Здесь был игрок: " + name);
        }
        public int Attack(int ammoA)
        {
            ammo -= ammoA;
            if (ammo > 0)
            {
                Console.WriteLine("Bang! Bang!");
            }
            else
            {
                ammo = 0;
            }
            return ammo;
        }
        public void Die()
        {
            Console.WriteLine("Player " + name + " game over");
        }
        public int Power
        {
            get
            {
                return ammo * health;
            }
        }
        public void Passport()
        {
            Console.WriteLine("Player {0} \t health = {1} ammo = {2}", name, health, ammo);
        }
    }
}
