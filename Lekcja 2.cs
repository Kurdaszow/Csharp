using System.Dynamic;
// using Internal;
using System;

public class Character 
{
	public int hp = 100;
	public int mana = 100;
    public int gold = 3000;
	public string name = "gigachad";
	public string rasa = "Czlowiek";

	public Enemy attack(Enemy enemy_to_kill) {
        
	    enemy_to_kill.hp -= 10;

        return enemy_to_kill;
    }
	public Enemy crit(Enemy enemy_to_crit){
		enemy_to_crit.hp = 0;

		return enemy_to_crit;
	}

	public override string ToString() {
		return "Nazywam się: " + name + " jestem: " + rasa + "iem i mam: "+ hp + "hp"; 
	}

    public Kupiec trade(Kupiec kupiec)
    {
        Console.WriteLine("wymien 2000 złota tak napisz -1 nie napisz -2 ");
        int wybor = Convert.ToInt32(Console.ReadLine());
        int gcheck = 2000;
        int missinggold;
        if (wybor==1){
            if(this.gold>gcheck){
                this.gold -=2000;
                kupiec.gold +=2000;
                Console.WriteLine("Wymieniono 2000 złota");
            } else
            {
                missinggold = gcheck-this.gold;
                Console.WriteLine("Nie masz wystarczająco złota,brakuje ci" + missinggold);
            }
        }
        return kupiec;
    }

}



public class Kupiec
{
    public string name = "Janusz";
    public int gold = 2500;


    public override string ToString() {
        return "Nazywam się " + name;
    }

}


public class Enemy 
{
	public int hp = 150;
	public int mana = 70;
	public string name = "Boxdil";
	public string rasa = "druid";

	public override string ToString() {
		return "Nazywam się: " + name + " jestem: " + rasa + "em i mam: " + hp + "hp";
	}

	public Character ettack(Character character_to_kill){
		character_to_kill.hp -=5;
		return character_to_kill;
	}


}

					
public class Program
{
	public static void Main()
	{
        Character myHero = new Character();
		Enemy druid = new Enemy();
		Kupiec Janusz = new Kupiec();
        string klasa;

        while (true)
            {
                Console.WriteLine("Wybierz klasę! Do wyboru masz:\nCzłowiek (wpisz Human)\n-----------------------------------");
                klasa = Console.ReadLine();
                if (klasa == "Human" || klasa =="human")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Nieobsługiwana klasa!\n----------------------------------------");
                }
            }
    
		Console.WriteLine("Witaj Człowieku zanim zaczniesz swoja przygode\nmusisz ujścić opłate wojenna w wysokosci 2000 złota \n-----------------------------------");
        while (true) {
            myHero.trade(Janusz);

            if (Janusz.gold>=3000){
            Console.WriteLine("Jestem usatysfakcjonowany, teraz możesz zacząc swoją walke z " + druid.name + "em");

            Console.WriteLine(druid);	
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(myHero);
            Console.WriteLine("\n---------------Walka start---------------\n");

            while(druid.hp>0){


                if(myHero.hp<=40){
                    Console.WriteLine("UDERZENIE KRYTYCZNE ");
                    myHero.crit(druid);

                } else {
                    myHero.attack(druid);
                }
                druid.ettack(myHero);
                Console.WriteLine("              Enemy HP:"+ druid.hp);
                Console.WriteLine("              Hero HP: "+myHero.hp);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("\nWalka wygrana Gratulacje człowieku ");
            break;
            
            } else {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Dopóki nie zapłacisz mi wystarczająco nie pozwole ci zawalczyć\n");
                
            }
		

}
    }
}