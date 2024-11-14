using Lab08;

namespace Lab08
{
    public interface IMonster
    {
        Location Location { get; set; }
        int Health { get; set; }
        int ArmorClass { get; set; }

        void Activate(Player player);
    }
}