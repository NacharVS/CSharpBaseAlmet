using static CSharpBaseAlmet.Weapons.Weapon;

namespace CSharpBaseAlmet
{
    class Unit
    {
        private int _health;
        public delegate void HealthChangedDelegate(int health);
        public Unit(string type, int health, int speed)
        {
            Type = type;
            MaxHealth = health;
            Health = health;     
            Speed = speed;
            Level = 1;
        }

        public int Level { get; set; }
        public string Type { get; set; }
        public bool IsStunned { get; set; }
        public bool IsOpenWounds { get; set; }
        public int MaxHealth { get; set; }
        public int Speed { get; set; }
        public int Health 
        {   get
            {
                return _health;
            }
            set
            {

                if(value < 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > MaxHealth)
                    {
                        _health = MaxHealth;
                    }
                    else
                    {
                        _health = value;
                    }
                }

                healthChangedDelegate?.Invoke(_health);
            }
        }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Type - {Type} Health - {Health} Speed - {Speed}");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Type} is moving to...");
        }

        public void GetDamageAndEffect((int, bool, string, int) damageEffect) 
        {

            if (damageEffect.Item4 <= 0)
            {
                Console.WriteLine($"{damageEffect.Item3} break. Damage - 2");
            }
            else 
            {
                Console.WriteLine($"{damageEffect.Item3} - {damageEffect.Item4}");
            }

            if (damageEffect.Item3 == "BronzeMace") 
            {
                Health -= damageEffect.Item1;
                Console.WriteLine(damageEffect.Item1);
                IsStunned = damageEffect.Item2;
            }
            if (damageEffect.Item3 == "StoneAxe") 
            {
                Health -= damageEffect.Item1;
                Console.WriteLine(damageEffect.Item1);
                IsOpenWounds = damageEffect.Item2;
                if (IsOpenWounds) 
                {
                    Health -= 2;
                    Console.WriteLine("Open wounds!");
                }
                return;
            }

        }
        public event HealthChangedDelegate healthChangedDelegate;



    }
}
