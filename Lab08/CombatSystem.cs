namespace Lab08
{
    public static class CombatSystem
    {
        private static Random random = new Random();

        public static void Engage(Player player, Monster monster)
        {
            while (player.Health > 0 && monster.Health > 0)
            {
                if (Attack(player, monster))
                {
                    Console.WriteLine("You hit the monster");
                    monster.TakeDamage(((Weapon)player.GetBestWeapon()).GetDamage(random));

                }
                else
                {
                    Console.WriteLine("You missed");
                }  

                if (monster.Health > 0 && Attack(monster, player))
                {
                    Console.WriteLine("The monster hits you");
                    player.TakeDamage(((Weapon)monster.GetBestWeapon()).GetDamage(random));
                } 
                else
                {
                    Console.WriteLine("The monster Missed");
                }
            }
            if (monster.Health <= 0)
            {
                Console.WriteLine("You defeated the monster");
                player.Inventory.AddRange(monster.Inventory);
            }
        }

        private static bool Attack(ICombatant attacker, ICombatant defender)
        {
            return attacker.RollAttack() >= defender.ArmorClass;
        }
    }
}