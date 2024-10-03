using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterIsh
{
    internal class Boss : GameCharacter
    {
        public Boss(string name, int health, int attackPower) : base(name, health, attackPower)
        {

        }

        public override int Attack()
        {
            return 340;
        }

    }
}
