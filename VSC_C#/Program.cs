using System;

public class Character 
{
	public int hp = 100;
	public int mana = 100;
	public string name = "Golik";
	public string rasa = "Human";

	public Enemy attack(Enemy enemy_to_kill) {
		if (hp > 120)
		{	
			enemy_to_kill.hp -= 10;
			return enemy_to_kill;
		}
		else if ( hp < 110)
		{
			enemy_to_kill.hp -= 30;
			return enemy_to_kill;
		}
	}

	public override string ToString() {
		return "Nazywam się: " + name;
	}
}

public class Enemy 
{
	public int hp = 130;
	public int mana = 700;
	public string name = "Boxdil";
	public string rasa = "ssak";

	public override string ToString() {
		return "Postać: " + name + " hp: " + hp;
	}
}

					
public class Program
{
	public static void Main()
	{
        Character myHero = new Character();
		Enemy wolf = new Enemy();

		Console.WriteLine(wolf);
		myHero.attack(wolf);

		Console.WriteLine(wolf);
		// Console.WriteLine(myHero);
		// Console.WriteLine(wolf);
	}
}