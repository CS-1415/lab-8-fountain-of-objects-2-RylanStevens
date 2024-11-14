namespace Lab08
{
    public class Potion : Item{
        public int HealingAmount { get; }

        public Potion(string name, int HealingAmount) : base(name)
        {
            HealingAmount = HealingAmount;
        }
    }
    public class Item{
        public string Name { get; set; }
        public int Value { get; set; }  
        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }
    }
}