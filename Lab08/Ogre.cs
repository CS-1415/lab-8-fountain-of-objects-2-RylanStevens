namespace Lab08
{
    public class Ogre : Monster
    {
        public Ogre(Location location, int health, int armorClass, Weapon weapon) : base(location, health, armorClass, weapon)
        {
            Inventory.Add(new Weapon("Club", 4, 6));
        }
        public override void Activate(Player player)
        {
            Console.WriteLine("The Ogre swings it's club");
            CombatSystem.Engage(player, this);
        }
    }
}