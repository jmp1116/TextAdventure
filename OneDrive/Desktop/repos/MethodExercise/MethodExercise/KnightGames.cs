using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MethodExercise
{
    class KnightGames
    {
        public KnightGames()
        {
                
        }
        public bool GameOne()
        {
            Console.WriteLine("Save me, 7 Suns!! A wizard is coming! Try to act natural, maybe he won't notice us!");
            Console.WriteLine("Wizard Says: Good day. A game to play, we must?");
            Console.WriteLine("No, no we really must be gettin-");
            Console.WriteLine("Wizard: Of course we will play! If you get my riddle wrong I will curse you and hurt you!");
            Console.WriteLine("Hit enter to play the Wizard's riddle.");
            Console.ReadLine();
            Console.WriteLine("How many 9's are between 1 & 100?");
            int answer = Int32.Parse(Console.ReadLine());
            if (answer == 20) return true;
            else return false;

        }

        public bool GameTwo()
        {
            Console.WriteLine("Wizard says: Now for another one!");
            Console.WriteLine("In two years I know, I'll be twice as old as five years ago, said Tomothus. How old is Tomothus?");
            int answer = Int32.Parse(Console.ReadLine());
            if (answer == 12) return true;
            else return false;

        }


        public bool GameThree()
        {
            Console.WriteLine("Troll says: Arrrggg... you want to pass thy bridge...??");
            Console.WriteLine( "Two questions you must answer- OR I BASH THY HEADS IN!!!");
            Console.WriteLine("Mom and Dad have four daughters, and each daughter has one brother." +
                " How many people are in the family ? ");
            int answer = Int32.Parse(Console.ReadLine());
            if (answer == 12) return true;
            else return false;

        }

        public bool GameFour()
        {
            Console.WriteLine("Troll says: Now For my last question!");
            Console.WriteLine("When my father was 31 I was 8. Now he is twice as old as me. How old am I ? ");
            int answer = Int32.Parse(Console.ReadLine());
            if (answer == 23) return true;
            else return false;


        }

        public bool GameFive()
        {
            Random rand = new Random();
            int answer = rand.Next(0, 100);

            Console.WriteLine("You get 7 triesssss to guessss my number 1-100 and I will tell you if you are over or under the number.");
            Console.WriteLine("If you get can't guessssss it in 7 triesssss I will burn 3 of your livessssss.");
            Console.WriteLine("Letsssss begin, guesssss a number.");

            for (int i = 0; i < 7; i++)
            {
                int num = Int32.Parse(Console.ReadLine());

                if (num == answer)
                {
                    Console.WriteLine("Impressssive. You may passsssss.");
                    return true;
                }
                else if (num < answer) Console.WriteLine("Higher. Guesssss again.");
                else Console.WriteLine("Lower. Guessss again.");

            }
            return false;
        }

    }

}
