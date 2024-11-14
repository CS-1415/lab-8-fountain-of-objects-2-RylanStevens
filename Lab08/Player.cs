namespace Lab08
{
    public class Player
    {
        public Location Location { get; set; }
        public int Health { get; private set; } = 100;
        public int ArmorClass { get; private set; } = 10;
        public List<Weapon> Inventory { get; private set; } = new List<Weapon>();
        
        public Player(Location startLocation)
        {
            Location = startLocation;
            Inventory.Add(new Weapon("Fist", 1, 3));
        }
        public Weapon StrongestWeapon() => Inventory.OrderByDescending(w => w.MaxDamage).First();

        public void TakeDamage(int amount)
        {
            Health -= amount;
            if (Health < 0) Health = 0;
        }
        

        public void AddWeapon(Weapon weapon)
        {
            Inventory.Add(weapon);
            Console.WriteLine($"You have found a {weapon.Name}");
        }
        public void Attack(Monster monster)
        {
            int attackRoll = new Random().Next(1, 21);
            if (attackRoll >= monster.ArmorClass)
            {
                int damage = StrongestWeapon().Damage();
                monster.Health -= damage;
                Console.WriteLine($"You attack the {monster.GetType().Name} for {damage} damage");
            }
            else
            {
                Console.WriteLine("You missed the attack");
            }
        }
    }
}