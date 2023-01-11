using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Game
{
    public void move()
    {
        int sides = 10;
        int height = 10;
        Character myHero = new Character();
        Enemy druid = new Enemy();
        Kupiec Janusz = new Kupiec();
        // string klasa;
        // public string x = 0; 
        ConsoleKeyInfo KeyInfo;
        do
        {

            Console.BackgroundColor = ConsoleColor.DarkGreen;


            KeyInfo = Console.ReadKey(true);
            Console.Clear();
            Console.SetCursorPosition(5, 5);

            Console.SetCursorPosition(10, 20);


            Console.SetCursorPosition(5, 5);


            switch (KeyInfo.Key)

            {
                case ConsoleKey.RightArrow:
                    sides++;
                    Console.SetCursorPosition(sides, height);
                    Console.Write("*");
                    break;
                case ConsoleKey.LeftArrow:
                    sides--;
                    Console.SetCursorPosition(sides, height);
                    Console.Write("*");
                    break;
                case ConsoleKey.UpArrow:
                    height--;
                    Console.SetCursorPosition(sides, height);
                    Console.Write("*");
                    break;
                case ConsoleKey.DownArrow:
                    height++;
                    Console.SetCursorPosition(sides, height);
                    Console.Write("*");
                    break;

            }
        } while (true);

        /*            while (true)
                    {
                        Console.WriteLine("Wybierz klasę! Do wyboru masz:\nCzłowiek (wpisz Human)\n-----------------------------------");
                        klasa = Console.ReadLine();
                        if (klasa == "Human" || klasa == "human")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Nieobsługiwana klasa!\n----------------------------------------");
                        }
                    }

                    Console.WriteLine("Witaj Człowieku zanim zaczniesz swoja przygode\nmusisz ujścić opłate wojenna w wysokosci 2000 złota \n-----------------------------------");
                    while (true)
                    {
                        myHero.trade(Janusz);

                        if (Janusz.gold >= 3000)
                        {
                            Console.WriteLine("Jestem usatysfakcjonowany, teraz możesz zacząc swoją walke z " + druid.name + "em");

                            Console.WriteLine(druid);
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine(myHero);
                            Console.WriteLine("\n---------------Walka start---------------\n");

                            while (druid.hp > 0)
                            {


                                if (myHero.hp <= 40)
                                {
                                    Console.WriteLine("UDERZENIE KRYTYCZNE ");
                                    myHero.crit(druid);

                                }
                                else
                                {
                                    myHero.attack(druid);
                                }
                                druid.ettack(myHero);
                                Console.WriteLine("              Enemy HP:" + druid.hp);
                                Console.WriteLine("              Hero HP: " + myHero.hp);
                                Console.WriteLine("-----------------------------------------");
                            }
                            Console.WriteLine("\nWalka wygrana Gratulacje człowieku ");
                            break;

                        }
                        else
                        {
                            Console.WriteLine("-----------------------------------------");
                            Console.WriteLine("Dopóki nie zapłacisz mi wystarczająco nie pozwole ci zawalczyć\n");

                        }*/


    
}
}
