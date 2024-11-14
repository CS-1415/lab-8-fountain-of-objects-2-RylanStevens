namespace Lab08
{
    public class Monster : ICombatant
    {
        public List<Item> Inventory { get; set; } = new List<Item>();
        public void AddItem(Item item)
        {
            Inventory.Add(item);
        }
    }
    public class FountainOfObjectsGame
    {
        public Map Map { get; }
        public Player Player { get; }
        public List<Monster> Monster = new List<Monster>();
        private Random random = new Random();

        public FountainOfObjectsGame(int width, int height, Location playerStartLocation)
        {
            Map = new Map(width, height);
            Player = new Player(playerStartLocation);
        }
        public void AddMonster(Monster monster)
        {
            monster.Add(monster);
        }
        
        public void EncounterMonster()
        {
            var currentMonster = monster.FirstOrDefault(m => m.Location.Equal(Player.Location));
            if (currentMonster != null)
            {
                Console.WriteLine($"You encounter a {currentMonster.GetType().Name}");
                currentMonster.Activate(Player);
                if (currentMonster.Health <= 0)
                {
                    Console.WriteLine($"You defeated the {currentMonster.GetType().Name}");
                    Player.AddWeapon(currentMonster.Weapon);
                    monsters.Remove(currentMonster);
                }
            }
        }
    }
}