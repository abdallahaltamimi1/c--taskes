using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    abstract class GameCharacter
    {
        //private string _name;
        private int health;
        public string Name { get; set; }
        protected int Health 
        { 
            get 
            { return health; }
            set {
                if(value>=0 && value<=100)
                {
                    health = value;
                }
                else if(value<0)
                {
                    health = 0;
                }
                else
                {
                    health = 100;
                }
            }
        }
        public GameCharacter(string name, int health)
        {
            // _name = name;
            this.Name = name;
            this.Health = health ;
        }
        public abstract void UseSpecialAbility();
        public abstract void TakeDamage(int amount);
       public void Heal()
        {
            Health += 10;
            Console.WriteLine($"{Name} heals 10 points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
        public void Heal(int amount)
        {
            Health += amount;
            Console.WriteLine($"{Name} heals {amount} points.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }

    }
}

