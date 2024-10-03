using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterIsh
{
    internal class Monster : GameCharacter
    {
        public Monster(string name, int health, int attackPower) : base(name, health, attackPower)
        {

        }

        public override int Attack()
        {
            return 155;
        }


    }
}
