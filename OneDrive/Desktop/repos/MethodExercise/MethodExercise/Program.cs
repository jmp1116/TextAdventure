using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            PlayerStats firstPlayerStats = new PlayerStats();// instantiate the stats class

            Console.WriteLine("Welcome to Knight's Adventure!");

            Console.WriteLine("Plase enter your name");

            firstPlayerStats.Name = Console.ReadLine(); //get name of player

            firstPlayerStats.ShowHealth(); // show the stats of player

            // introduce the game
            Console.WriteLine($"Good morro, Sir {firstPlayerStats.Name}!");
            Console.WriteLine("How doth yee feel on this fine winter's eve?");
            Console.WriteLine("My name is Sir Johnothus, first of thy name, son of Marcus!");
            Console.WriteLine("I hear tell that you want to cross the great plains to rescue the princess?!");
            Console.WriteLine("There are a few obstacles and enemies we must defeat to get to her!");
            Console.WriteLine("FEAR NOT! FOR THE DAY IS LONG AND WE ARE YOUNG! Let us begin!");
            Console.WriteLine("Hit enter to continue on the quest to save the beautiful princess.");
            Console.ReadLine();
            Console.WriteLine("After 2 days of walking, a wizard approaches.");

            KnightGames firstGame = new KnightGames(); //instantiate the knightgames class

            //there will be 5 games that must be completed. they start now

            //game one is bool and if fails it returns false and takes a health point
            if (firstGame.GameOne() == true) Console.WriteLine("Very good! Now for my next riddle!");
            else
            {
                firstPlayerStats.HealthDown();
                Console.WriteLine("AH! Alas! You must pay for you incompetence!");
            }

            firstPlayerStats.ShowHealth(); // show the stats of player


             //game two is bool and if fails it returns false and takes health down another point
            if (firstGame.GameTwo() == true) Console.WriteLine("Very good!!");
            else
            { 
                Console.WriteLine("AWW lick-a-toad! I curse you!");
                firstPlayerStats.HealthDown();
            }
            Console.WriteLine("Wizard says: Good day to you both! may your travels be easy!");

            firstPlayerStats.ShowHealth(); // show the stats of player

            Console.WriteLine("Hit enter to continue past the wizard.");
            Console.ReadLine();
            Console.WriteLine("As the pair strolls away, Johnathus says: Wizards are lame.");
            Console.WriteLine("After another day of walking, the pair approaches a bridge with a troll gaurding it.");
            Console.WriteLine("Johnathus says: We must go over the bridge for there are sirens in the river that will eat us.");
            Console.WriteLine("Hit enter to continue on towards the troll.");
            Console.ReadLine();



            //game three is bool and if fails it returns false and takes health down another point
            if (firstGame.GameThree() == true) Console.WriteLine("You are right... You clown.");
            else
            {
                firstPlayerStats.HealthDown();
                Console.WriteLine("Troll says: Ha I will smash you with my club! !!!POW!!!");
            }


            firstPlayerStats.ShowHealth(); // show the stats of player



            //game four is bool and if fails it returns false and takes health down another point
            if (firstGame.GameFour() == true) Console.WriteLine("You are right... You shall pass.");
            else
            {
                firstPlayerStats.HealthDown();
                Console.WriteLine("Troll says: Ha I will smash you with my club! !!!POW!!!");
            }


            firstPlayerStats.ShowHealth(); // show the stats of player

            Console.WriteLine("Hit enter to continue across the bridge.");
            Console.ReadLine();
            Console.WriteLine("The pair passed the bridge and continued on their journey.");
            Console.WriteLine("After 2 more days, a dreary looking castle grew upon the horizon. Johnothus says:");
            Console.WriteLine("Worry not, my friend! For we are approaching the Castle de Muerto!");
            Console.WriteLine("Now comes the toughest of our journey, for we must get past the dragon in order to rescue the princess from the castle!");
            Console.WriteLine("The pair entered the dark and musty castle door into a musty great hall.");
            Console.WriteLine("BOOM! The pair fall to the ground as the castle rumbles as if there was an earthquake.");
            Console.WriteLine("Suddenly they hear a slithering voice slimily say:");
            Console.WriteLine("Whooo daresssssssssss entersssss my lair?");
            Console.WriteLine("Do you not know who I am?");
            Console.WriteLine("We will play a game.");
            Console.WriteLine("Hit enter to play the dragon's game.");
            Console.ReadLine();

            //game five is bool guess number game and if fails it returns false and takes health down 3 points
            if (firstGame.GameFive() == true) Console.WriteLine("You are right... You shall passssss.");
            else
            {
                firstPlayerStats.HealthDown();
                firstPlayerStats.HealthDown();
                firstPlayerStats.HealthDown();
                Console.WriteLine("RARRRR!!!");
                Console.WriteLine("Dragon hissess and burns both knights up with a stream of fire!!!");
            }
            Console.WriteLine("Hit enter to continue past the dragon to the princess.");
            Console.ReadLine();
            Console.WriteLine("Johnothus looks at you and says:");
            Console.WriteLine("By the heavens above! We made it!");
            Console.WriteLine("The two knights go and find the princess who is the most beautiful woman in all the lands.");
            Console.WriteLine($"The princess looks at you, {firstPlayerStats.Name}");
            Console.WriteLine("Then she looks at Johnothus and says:");
            Console.WriteLine("OH BABY- Johnothus! You came for me!");
            Console.WriteLine("Johnothus takes her arm and they run away leaving you alone.");
            Console.WriteLine("Johnothus lied to you and duped you. Then you realize....");
            Console.WriteLine("Johnothus wasn't a knight. He was a 400 foot tall monster from the paleolithic period.");
            Console.WriteLine("He sticks his head back in the door and says: do you have tree-fitty?");




        }
           
    }
}
