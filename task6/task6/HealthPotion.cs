using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    internal class HealthPotion : ICollectible
    {
        public void Collect()
        {
            Console.WriteLine("Health potion collected!");
        }
        public string PotionName { get; set; }
        public void Use(GameCharacter character, string amountText)
        {
            
            
            try
            {
                int amount = int.Parse(amountText);
                Console.WriteLine($"The {character.Name} uses a {PotionName}!");
                character.Heal(amount);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a number.");
            }
           


        }
    }
}
