namespace Lab08
{
    public class Goblin : Monster
    {
        public Goblin(Location location) : base(location, 10, 8, new Weapon("Dagger", 1, 4)) { }
        public override void Activate(Player player)
        {
            Attack(player);
        }
    }
    
}