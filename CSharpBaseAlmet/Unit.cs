namespace CSharpBaseAlmet
{
    class Unit
    {
        public Unit(string type, int health, int speed)
        {
            Type = type;
            Health = health;
            Speed = speed;
            Level = 1;
        }

        public int Level { get; set; }
        public string Type { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Type - {Type} Health - {Health} Speed - {Speed}");
        }

        public void Move()
        {
            Console.WriteLine($"{Type} is moving to...");
        }


    }
}
