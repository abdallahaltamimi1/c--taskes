using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Wizard : GameCharacter
    {
        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Wizard uses magic!");
        }
        public Wizard(string name, int health) : base(name, health)
        {
        }
        public override void TakeDamage(int amount)
        {
            Health -= amount;

            Console.WriteLine($"{Name} takes {amount} damage.");
            Console.WriteLine($"{Name}'s health: {Health}");
        }
        

    }
}
