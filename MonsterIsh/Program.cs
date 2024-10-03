namespace MonsterIsh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player warrior = new Player("Grimwald", 300, 225);

            Weapon axe = new Weapon("Axe", 250);
            Weapon broadSword = new Weapon("Broadsword", 210);
            Weapon mace = new Weapon("Mace", 285);
            Weapon dagger = new Weapon("Dagger", 175);
            Weapon bow = new Weapon("Bow", 210);

            warrior.weapons.Add(axe);
            warrior.weapons.Add(broadSword);
            warrior.weapons.Add(mace);
            warrior.weapons.Add(dagger);
            warrior.weapons.Add(bow);

            warrior.ChooseWeapon();





        }
    }
}

