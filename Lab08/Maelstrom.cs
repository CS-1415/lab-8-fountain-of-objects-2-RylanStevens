namespace Lab08
{
    public class Maelstrom : Monster
    {
        public Maelstrom(Location location) : base(location, 15, 12, new Weapon("Maelstrom's Claws", 3, 7)) {}
        
        public override void Activate(Player player)
        {
            if (new Random().Next(2) == 0)
            {
                Console.WriteLine("The Maelstrom teleports you ");
                player.Location = new Location(new Random().Next(5), new Random().Next(5));
            }
            else
            {
                Attack(player);
            }
        }
        
    }
}