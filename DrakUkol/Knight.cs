
namespace KnightDragonHomework
{
    public class Knight
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Armor { get; set; }

        public Knight(string name, string lastName, int hitPoints, int strength, int agility, int armor)
        {
            Name = name;
            LastName = lastName;
            HitPoints = hitPoints;
            Strength = strength;
            Agility = agility;
            Armor = armor;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Knight: {Name} {LastName}");
            Console.WriteLine($"Hit Points: {HitPoints}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Armor: {Armor}");
        }

        public void AttackDragon(Dragon headNumbers)
        {
            while (headNumbers.NumberOfHeads > 0)
            {
                Console.WriteLine($"Oooooo, mighty knight {Name}, borned {LastName}, is attacking the dragon!");
                headNumbers.HitByKnight();
            }
        }

    }
}