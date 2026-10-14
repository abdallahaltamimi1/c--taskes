using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior war1 = new Warrior("Warrior1", 100);
            Wizard wizard1 = new Wizard("Wizard1", 80);
            Console.WriteLine();
            GameCharacter[] characters = new GameCharacter[] { war1, wizard1 };
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i].UseSpecialAbility();
                characters[i].TakeDamage(20);


            }
           
            war1.Heal(10);
            wizard1.Heal();
            HealthPotion potion = new HealthPotion();
            potion.PotionName = "Health Potion";
            potion.Collect();
            potion.Use(war1, "15");
            potion.Use(wizard1, "aaa");

        }

    }
}
