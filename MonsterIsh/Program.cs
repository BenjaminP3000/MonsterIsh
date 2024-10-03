namespace MonsterIsh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player warrior = new Player("Grimwald", 300, 225);
            Monster yeti = new Monster("Grobo", 400, 150);
            Boss wendigo = new Boss("Gynaz", 700, 340);

            List<GameCharacter> list = new List<GameCharacter>();
            list.Add(warrior);
            list.Add(yeti); 
            list.Add(wendigo);            

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

            Console.WriteLine("Welcome to MonsterIsh!\n");
            Console.ReadKey();  
            warrior.ChooseWeapon();
            Console.ReadKey();

            while (true)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Attack();
                }

            }





        }
    }
}

