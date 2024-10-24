namespace PolymorphismAndInterfaceExample
{
    public class Goblin : IAttackable
    {
        public int Health { get; set; } = 10;

        public void Attacked (int damage)
        {
            Health -= damage;
            Console.WriteLine($"Goblin hit for {damage} damage! Health: {Health}");
            if (Health <= 0)
            {
                Console.WriteLine("Goblin defeated!");
            }
        }
    }