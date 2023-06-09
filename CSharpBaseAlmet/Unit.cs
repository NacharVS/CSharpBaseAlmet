﻿namespace CSharpBaseAlmet
{
    class Unit
    {   
        public delegate void HealthChangedDelegate(int health);
 
        private int _health;
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

        public int MaxHealth { get; set; }
        public int Speed { get; set; }

        public  bool IsStunned { get; set; }
        public bool IsBleeding { get; set; }
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
                healthChangedEvent?.Invoke(_health);
            }
        }

        public void ShowBaseInfo()
        {
            Console.WriteLine($"Type - {Type} Health - {Health} Speed - {Speed}");
        }

        public void Move()
        {

        }

        public void GetDamageAndEffect((int,bool,string)damageEffect)
        {
            if(damageEffect.Item3 == "BronzeMace")
            {
                Health -= damageEffect.Item1;
                Console.WriteLine(damageEffect.Item1);
                IsStunned = damageEffect.Item2;
                return;
            }
            if(damageEffect.Item3 == "StoneAxe")
            {
                Health -= damageEffect.Item1;
                Console.WriteLine(damageEffect.Item1);
                IsBleeding = damageEffect.Item2;
                return;
            }

        }

        public event HealthChangedDelegate healthChangedEvent;
    }
}
