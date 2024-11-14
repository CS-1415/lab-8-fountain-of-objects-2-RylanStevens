namespace Lab08
{
    public class Amarok : Monster
    {
        public Amarok(Location location) : base(location, 20, 14, new Weapon("Amarok's Bite", 5, 10)) { }
        public override void Activate(Player player)
        {
            Attack(player);
        }
    }
}