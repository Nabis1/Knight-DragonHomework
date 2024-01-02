
namespace KnightDragonHomework
{
    public class Dragon
    {
        public string Name { get; set; }
        public int NumberOfHeads { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Armor { get; set; }

        public Dragon(string name, int headNumbers, int strength, int agility, int armor)
        {
            Name = name;
            NumberOfHeads = headNumbers;
            Strength = strength;
            Agility = agility;
            Armor = armor;
        }
        public void DisplayDragonInfo()
        {
            Console.WriteLine($"Dragon: {Name}");
            Console.WriteLine($"Number of heads: {NumberOfHeads}");
            Console.WriteLine($"Strength: {Strength}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Armor: {Armor}");
        }
        public void HitByKnight()
        {
            if (NumberOfHeads > 0)
            {
                NumberOfHeads--;

                if (NumberOfHeads > 0)
                {
                    Console.WriteLine("Deathwing is shouting in pain : Where is my head!");
                }
                else
                {
                    Console.WriteLine("I'm defeated...");
                }
            }
            else
            {
                Console.WriteLine("The dragon is already defeated!");
            }
        }
    }
}
