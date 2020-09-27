using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MethodExercise
{
    class PlayerStats
    {
        
        private int health = 5;
        public string Name { get; set; }

        public int HealthDown()
        { 
            if (health <= 0)
            {
                Console.WriteLine("Game over you died.");
                System.Environment.Exit(0);
            }
            return health = health - 1;
        }
        public void ShowHealth()
        {
            Console.WriteLine("Your health is:");
            Console.WriteLine(health);
        }
        public PlayerStats()
        {
             
        }
        public PlayerStats(string name)
        {
            health = 5; // sets initital health   
            Name = name;
        }


    }





}
