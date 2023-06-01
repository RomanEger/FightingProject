using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public abstract class Person
    {
        public int lastEnemyHit = 0;

        public Random random = new Random();

        public static int minHeadDmg = 10;
        public static int maxHeadDmg = 13;

        public static int minBodyDmg = 8;
        public static int maxBodyDmg = 11;

        public static int minLegDmg = 6;
        public static int maxLegDmg = 9;

        private int hp = 100;
        public int HP
        {
            get { return hp; }
            set 
            { 
                if(value >= 80 && value <= 110)
                    hp = value; 
            }
        }

        private int hill;
        public int Hill
        {
            get { return hill; }
            set { hill = (int)Math.Ceiling(value / 10.0); }
        }

        public int damage;

        private int personHit;

        public int block;
        
        public int PersonHit
        {
            get { return personHit; } 
            set
            {
                personHit = value;
            }
        }

        public int MakeBlock(int hit, int block)
        {
            if (hit == block)
                return this.block = random.Next(70, 101);
            else
                return 0;
        }

        private static int choice;
        public int Choice
        {
            get { return choice; }
            set { choice = value; }
        }
    }

    public class Player : Person
    {
        public Player(int choice)
        {
            Choice = choice;
            switch (choice)
            {
                case 2:
                    {
                        minHeadDmg = 12;
                        maxHeadDmg = 15;

                        minBodyDmg = 10;
                        maxBodyDmg = 13;

                        minLegDmg = 8;
                        maxLegDmg = 11;

                        HP = 80;
                    }
                    break;
                case 3:
                    {
                        minHeadDmg = 9;
                        maxHeadDmg = 11;

                        minBodyDmg = 7;
                        maxBodyDmg = 10;

                        minLegDmg = 6;
                        maxLegDmg = 9;

                        HP = 110;
                    }
                    break;
                case 4:
                    {
                        HP = 85;
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Позволяет нанести крит удар (вероятность 30%)
        /// </summary>
        /// <param name="Кнопка удара"></param>
        /// <returns></returns>
        public int CriticalHit(Button button)
        {
            int x = random.Next(1, 11);
            if (x <= 3)
            {
                if (button.Name == "btnHitHead")
                    return random.Next(50, 61);
                else if (button.Name == "btnHitBody")
                    return random.Next(70, 81);
                else if (button.Name == "btnHitLeg")
                    return random.Next(80, 91);
                else
                    return 0;
            }
            else
                return 0;
        }


        /// <summary>
        /// Позволяет нанести урон
        /// </summary>
        /// <param name="Кнопка удара"></param>
        /// <returns></returns>
        public int DoDamage(Button button)
        {
            if (button.Name == "btnHitHead")
            {
                PersonHit = random.Next(minHeadDmg, maxHeadDmg);
                return damage = PersonHit + (int)Math.Ceiling(PersonHit * CriticalHit(button) / 100.0);
            }
            else if (button.Name == "btnHitBody")
            {
                PersonHit = random.Next(minBodyDmg, maxBodyDmg);
                return damage = PersonHit + (int)Math.Ceiling(PersonHit * CriticalHit(button) / 100.0);
            }
            else if (button.Name == "btnHitLeg")
            {
                PersonHit = random.Next(minLegDmg, maxLegDmg);
                return damage = PersonHit + (int)Math.Ceiling(PersonHit * CriticalHit(button) / 100.0);
            }
            else
                return 0;
        }
    }

    public class Enemy : Person
    {

        /// <summary>
        /// Позволяет нанести крит удар (вероятность 30%)
        /// </summary>
        /// <returns></returns>
        public int CriticalHit(int hit)
        {
            int x = random.Next(1, 11);
            if (x <= 3)
            {
                if (hit == 1)
                {
                    return random.Next(50, 61);
                }
                else if (hit == 2)
                {
                    return random.Next(70, 81);
                }
                else
                {
                    return random.Next(80, 91);
                }
            }
            else
                return 0;
        }


        /// <summary>
        /// Позволяет нанести урон
        /// </summary>
        /// <param name="onHit">Часть тела, по которой наносится удар</param>
        /// <returns>Возвращает нанесенный урон</returns>
        public int DoDamage(out int onHit)
        {
            do
            {
                onHit = random.Next(1, 4);
            } while (lastEnemyHit == onHit);
            if (onHit == 1 && onHit != lastEnemyHit)
            {
                lastEnemyHit = 1;
                PersonHit = random.Next(10, 13);
                return damage = PersonHit + (int)Math.Ceiling(PersonHit * CriticalHit(onHit) / 100.0);
            }
            else if (onHit == 2 && onHit != lastEnemyHit)
            {
                lastEnemyHit = 2;
                PersonHit = random.Next(8, 11);
                return damage = PersonHit + (int)Math.Ceiling(PersonHit * CriticalHit(onHit) / 100.0);
            }
            else if (onHit == 3 && onHit != lastEnemyHit) 
            {
                lastEnemyHit = 3;   
                PersonHit = random.Next(6, 9);
                return damage = PersonHit + (int)Math.Ceiling(PersonHit * CriticalHit(onHit) / 100.0);
            }
            else
            {
                return DoDamage(out onHit);
            }
        }

        
    }

    
}
