namespace Lab08
{
    public interface ICombatant
    {
        string? Name { get; set; }
        int Health { get; set; }
        int ArmorClass { get; }
        List<Item> Inventory { get; }

        int RollAttack();
        void TakeDamage(int amount);
        Item GetBestWeapon();
    }
    public class Item{
        public string Name { get; set; }
        public int Value { get; set; }
    }
}