using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class Character
    {
        public int hp = 100;
        public int mana = 100;
        public int gold = 3000;
        public string name = "gigachad";
        public string rasa = "Czlowiek";

        public Enemy attack(Enemy enemy_to_kill)
        {

            enemy_to_kill.hp -= 10;

            return enemy_to_kill;
        }
        public Enemy crit(Enemy enemy_to_crit)
        {
            enemy_to_crit.hp = 0;

            return enemy_to_crit;
        }

        public override string ToString()
        {
            return "Nazywam się: " + name + " jestem: " + rasa + "iem i mam: " + hp + "hp";
        }

        public Kupiec trade(Kupiec kupiec)
        {
            Console.WriteLine("wymien 2000 złota tak -1 nie  -2 ");
            int wybor = Convert.ToInt32(Console.ReadLine());
            int gcheck = 2000;
            int missinggold;
            if (wybor == 1)
            {
                if (this.gold > gcheck)
                {
                    this.gold -= 2000;
                    kupiec.gold += 2000;
                    Console.WriteLine("Wymieniono 2000 złota");
                }
                else
                {
                    missinggold = gcheck - this.gold;
                    Console.WriteLine("Nie masz wystarczająco złota,brakuje ci" + missinggold);
                }
            }
            return kupiec;
        }
    }

