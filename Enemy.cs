using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Enemy
{
    public int hp = 150;
    public int mana = 70;
    public string name = "Boxdil";
    public string rasa = "druid";

    public override string ToString()
    {
        return "Nazywam się: " + name + " jestem: " + rasa + "em i mam: " + hp + "hp";
    }

    public Character ettack(Character character_to_kill)
    {
        character_to_kill.hp -= 5;
        return character_to_kill;
    }


}