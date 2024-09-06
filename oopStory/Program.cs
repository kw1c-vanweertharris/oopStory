using System;
using System.ComponentModel.Design;

namespace firstProject
{
    public class Story
    {
        public int dragonHealth;
        public string name;
        public int health;

        public void Greeting()
        {
            Console.WriteLine($"Hello, {name}! Welcome to the story.");
        }

        public void ShowHealth()
        {
            Console.WriteLine($"Your health is currently: {health}");
        }

        public void TakeDamage()
        {
            int damage = 30;
            health -= damage;
            if (health < 0)
                health = 0; // Ensure health doesn't go below 0
            Console.WriteLine($"You took {damage} damage! Your health is now {health}.");
        }

        public void doDamage()
        {
            int damage = 30;
            dragonHealth -= damage;
            if (dragonHealth < 0)
                health = 0; // Ensure health doesn't go below 0
            Console.WriteLine($"You did {damage} damage! the dragons health is now {dragonHealth}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Story player = new Story();
            Console.WriteLine("What is the name of your player?");
            player.name = Console.ReadLine();
            player.health = 100;
            player.Greeting();
            player.dragonHealth = 100;

            while (true)
            {
                Console.WriteLine("Type 'hp' to check your health or 'exit' to quit:");
                string check = Console.ReadLine().ToLower();

                if (check == "hp")
                {
                    player.ShowHealth();
                }

                else if (check == "exit")
                {
                    Console.WriteLine("Exiting the game.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }

                //Main story is here
                Console.WriteLine("Once upon a time, in a land filled with mystery and magic...");
                Thread.Sleep(1200);
                Console.WriteLine("A brave knight was summoned to the royal court.");
                Thread.Sleep(1200);
                Console.WriteLine("The kingdom was under threat from a terrible dragon, spreading fear and destruction across the land.");
                Thread.Sleep(1200);
                Console.WriteLine("You, brave knight, have been chosen to embark on a dangerous quest to slay the dragon.");
                Thread.Sleep(1200);
                Console.WriteLine("With nothing but your sword and courage, you set off on your journey.");
                Thread.Sleep(1200);
                Console.WriteLine("The path ahead is treacherous, filled with wild beasts and dark forests.");
                Thread.Sleep(1200);
                Console.WriteLine("But your mission is clear: defeat the dragon, or perish trying.");
                Thread.Sleep(1200);
                Console.WriteLine("Will you have the strength to face the great beast and save the kingdom?");
                Thread.Sleep(1200);
                Console.WriteLine("Your journey begins now...");

                //dragon fight;
                Console.WriteLine(" ");//spaces for a cleaner lay out
                Console.WriteLine(" ");
                Console.WriteLine("a terribly large dragon appears and roars");
                Console.WriteLine("what do you do? a:dodge his flame b:hide behind your shield");
                string firstAttack = Console.ReadLine();
                if (firstAttack == "a")
                {
                    Console.WriteLine("well done you escaped the dragons first attack");
                }
                else if ((firstAttack == "b"))
                {
                    player.TakeDamage();
                    Console.WriteLine("the dragon heavily burned you maybe you shouldve dodged...");
                }
                else
                {
                    Console.WriteLine("wrong input");
                }

                //second attack
                Console.WriteLine("the dragon seems to be recharging his dragon breath for a second attack!");
                Console.WriteLine("what do you do? a:wait it off and hide behind a rock b:go in for a risky quick slash");
                string secondAttack = Console.ReadLine();
                if (secondAttack == "a")
                {
                    Console.WriteLine("behind the rock you found a weird potion and drank it.It gave you +30 health!");
                    player.health += 30;
                    player.ShowHealth();
                }
                else if(secondAttack == "b")
                {
                    Console.WriteLine("you were able to hit the dragon while it was charging good job!");
                    player.doDamage();
                }
                else { Console.WriteLine("wrong input detected"); };
                Console.WriteLine("the dragon is now almost ready for his heavy dragon breath attack!");
                Console.WriteLine("what do you do? a:stay behind the rock again b:charge the dragon with all your might!");
                string thirdAttack = Console.ReadLine();
                if (thirdAttack == "a")
                {
                    Console.WriteLine("the dragon flies over the rock and burned you to a crisp!");
                    Console.WriteLine("You died!!");
                    player.health -= 1000;
                }
                else if (thirdAttack == "b")
                {
                    Console.WriteLine("the dragon didnt excpect this at all and you were able to push the sword in the dragons heart!");
                    Console.WriteLine("the dragon falls to the ground you killed him!");
                }
                else { Console.WriteLine("wrond input"); }
            }
        }
    }
}
