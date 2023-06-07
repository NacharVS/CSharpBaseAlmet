using CSharpBaseAlmet.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBaseAlmet
{
    internal class Footman : BattleUnit
    {
        public Weapon CurrentWeapon { get; set; }
        public Footman(string type, int health, int speed, int damage, int defense) : base(type, health, speed, damage, defense)
        {
        }
        public Footman(string type, int health, int speed, int damage, int defense, Weapon weapon) : base(type, health, speed, damage, defense)
        {
            CurrentWeapon = weapon;
        }

        public override void InflictDamage(Unit anyUnit)
        {
            if(CurrentWeapon != null && CurrentWeapon.Durability>0)
            {
                anyUnit.GetDamageAndEffect(CurrentWeapon.Hit());
                CurrentWeapon.Durability -= 10;
            }
            else
            {
                base.InflictDamage(anyUnit);
                CurrentWeapon.Durability -= 2;
            }
        }



        public override void Move()
        {
            Console.WriteLine("Warrior going to the barracs");
        }
    }
}
