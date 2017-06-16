using System;

namespace Task_06
{
    public class Bonuses
    {
        public string bon;
        public int left;
        public Bonuses()
        {
            bon = "bonus";
            left = 0;
        }
        public Bonuses(string bon, int left)
        {
            this.bon = bon;
            this.left = left;
        }
        public void Passport()
        {
            Console.WriteLine("Bonuses {0} \t ", left);
        }
        public int[] tmp = new int[7];
        public Array arrBonuses()
        {
            Random rnd = new Random();
            int k = 7; //количество бонусов
            Bonuses[] GroupBon = new Bonuses[k];
            string[] s = { "bon1", "bon2", "вода", "мед", "абрикос", "вишня", "яблоко" };
            for (int i = 0; i < k; i++)
            {
                left = rnd.Next(1, 5);
                tmp[i] = left;
                bon = s[i];
                GroupBon[i] = new Bonuses(bon, left);
                Passport();
            }
            return GroupBon;
        }
        //увеличиваем здоровье игрока за счет бонуса
        public static Bonuses operator ++(Bonuses b)
        {
            Bonuses temp = new Bonuses();
            temp.left = b.left + 1;
            return temp;
        }
    }
}
