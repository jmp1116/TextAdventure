using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //This sections introduces the program and gets the user input.
            Console.WriteLine("Welcome to the adlib program.");
            Console.WriteLine("I am going to ask you for your words and I will put them in a story.. Let's begin.");

            Console.WriteLine("Tell me your favorite color.");
            string color = Console.ReadLine();

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite car?");
            string car = Console.ReadLine();

            Console.WriteLine("Where did you go to high school?");
            string school = Console.ReadLine();

            Console.WriteLine("Who was your crush in high school?");
            string crush = Console.ReadLine();


            Console.WriteLine("Are you a male?");

            string sex = Console.ReadLine();

            //Theres an else-if statement for male or female that tells a short story.

            if (sex.ToLower() == "yes")
            {
                Console.WriteLine($"One day there was a boy named {name} and he went to {school}.");
                Console.WriteLine($"On that day, {name} was driving a {car} when he saw {crush}.");
                Console.WriteLine($"When {name} saw {crush} he almost wrecked his {car}.");
                Console.WriteLine($"Fortunately, a {animal} ran out in front of {name} and scared him into slamming on the breaks.");
                Console.WriteLine("That's my story and I'm sticking to it.");
            }
            else
            {
                Console.WriteLine($"One day there was a girl named {name} and she went to {school}.");
                Console.WriteLine($"On that day, {name} was walking when she saw a {car} being driven by {crush}.");
                Console.WriteLine($"When {name} saw {crush} he was driving like a drunk person and almost wrecked his {car}.");
                Console.WriteLine($"Fortunately, a {animal} ran out in front of {crush} and scared him into slamming on the breaks.");
                Console.WriteLine("That's my story and I'm sticking to it.");
            }
            
            
           
        }
           
    }
}
