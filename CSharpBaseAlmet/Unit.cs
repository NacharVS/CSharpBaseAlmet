namespace CSharpBaseAlmet
{
    class Unit
    {
        public Unit(string type, int health, int speed, int defense)
        {
            Type = type;
            Health = health;
            Speed = speed;
            Defense = defense;
        }

        public string Type { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Defense { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"Type - {Type} Health - {Health}");
        }

        public static void CreateUnit()
        {
            Console.WriteLine("Unit has created");
        }

        public void GetDamage(int damage)
        {
            Console.WriteLine($"{Type} got {damage} of damage;");
            if (Health <= damage)
            {
                Console.WriteLine("Destroyed");
                Health = 0;
            }
            else
            {
                Health -= damage;
            }            
        }

    }
}
