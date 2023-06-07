using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class BattleUnit : Unit
    {
        public BattleUnit(string type, int health, int speed, int damage, int defense) : base(type, health, speed)
        {
            Damage = damage;
            Defense = defense;
        }

        public int Damage { get; set; }
        public int Defense { get; set; }

        public virtual void InflictDamage(Unit anyUnit)
        {
            anyUnit.Health -= Damage;
            Console.WriteLine($"{Type} inflicted {Damage} to enemy " +
                $"{anyUnit.Type}. Enemy health - {anyUnit.Health}");
        }



    }
}
