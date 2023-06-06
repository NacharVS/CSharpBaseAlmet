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


    }
}
