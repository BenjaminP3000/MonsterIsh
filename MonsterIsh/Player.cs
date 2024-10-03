using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterIsh
{
    internal class Player : GameCharacter
    {
        public List<Weapon> weapons = new List<Weapon>();
        private Weapon weaponOfChoice;
        public Player(string name, int health, int attackPower) : base(name, health, attackPower)
        {

        }

        public void ChooseWeapon()
        {
            Console.WriteLine("Available weapons: ");
            foreach (var weapon in weapons)
            {
                Console.WriteLine($"Weapon: {weapon.Name}, damage:{weapon.Damage}");
            }

            Console.Write("\nChoose your weapon: ");
            string userChoice = Console.ReadLine();

            for (int i = weapons.Count - 1; i >= 0; i--)
            {
                if (weapons[i].Name.ToLower().Contains(userChoice.ToLower()))
                {
                    weaponOfChoice = weapons[i];    
                    break;
                }
            }
            Console.WriteLine($"You are now using the {weaponOfChoice.Name}");
        }
        
        public override int Attack()
        {
            return AttackPower * (weaponOfChoice.Damage / 100);
        }



    }
}
