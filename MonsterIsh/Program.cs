namespace MonsterIsh
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player warrior = new Player("Grimwald", 5000, 225);
            Monster yeti = new Monster("Grobo", 4000, 150);
            Boss wendigo = new Boss("Gynaz", 7000, 340);

            List<GameCharacter> list = new List<GameCharacter>();
            list.Add(warrior);
            list.Add(yeti); 
            list.Add(wendigo);            

            Weapon axe = new Weapon("Axe", 250);
            Weapon broadSword = new Weapon("Sword", 210);
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

            Console.WriteLine("\nThe battle begins!");
            bool casualty = true;
            while (casualty)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i].Attack();
                    Console.WriteLine($"\n{list[i].Name} attacks!");
                    for (int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == list[i])
                        {
                            continue;
                        }
                        else
                        {
                            list[j].Health =- list[i].Attack();
                            Console.WriteLine($"{list[j].Name} takes {list[i].Attack()} damage.");
                            if (list[j].Health <= 0)
                            {
                                Console.WriteLine($"{list[j].Name} dies!");  
                                casualty = false;
                            }
                        }
                    }

                }
            }
        }
    }
}

