using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Warrior : GameCharacter
    {
        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }
        public Warrior(string name, int health) : base(name, health)
        {
        }
        public override void TakeDamage(int amount)
        {
            int reducedDamage = amount - 2;

            if (reducedDamage < 0)
            {
                reducedDamage = 0;
            }

            Health -= reducedDamage;

            Console.WriteLine($"{Name} takes {reducedDamage} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
    }
}
