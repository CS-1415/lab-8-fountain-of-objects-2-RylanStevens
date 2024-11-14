using Lab08;

namespace Lab08
{
    public class Monster : IMonster
    {
        public Location Location { get; set; }
        public int Health { get; set; }
        public int ArmorClass { get; set; }
        public Weapon Weapon { get; set; }

        
       

        protected Monster(Location location, int health, int armorClass, Weapon weapon)
        {
            Location = location;
            Health = health;
            ArmorClass = armorClass;
            Weapon = weapon;
        }
        public virtual void Attack(Player player)
        {
            int attackRoll = new Random().Next(1, 21);
            if (attackRoll >= player.ArmorClass)
            {
                int damage = Weapon.Damage();
                player.TakeDamage(damage);
                Console.WriteLine($"The {GetType().Name} attakcs and hits for {damage} damage");
                
            }
            else
            {
                Console.WriteLine($"The {GetType().Name} misses the attack");
            }
        }

        public virtual void Activate(Player player)
        {
            Console.WriteLine("Monster activates and engages with player");
        }
        
    }
    
}