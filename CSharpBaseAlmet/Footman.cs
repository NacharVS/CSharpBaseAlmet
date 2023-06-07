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
        public Footman(string type, int health, int speed, int damage, int defense) : base(type, health, speed, damage, defense)
        {
        }
        public Footman(string type, int health, int speed, int damage, int defense, Weapon weapon) : base(type, health, speed, damage, defense)
        {
            CurrentWeapon = weapon;
        }

        public override void InflictDamage(Unit anyUnit)
        {
            if(CurrentWeapon == null || CurrentWeapon.Durabiblty <= 0)
            {
                base.InflictDamage(anyUnit);
                return;
            };
            anyUnit.GetDamageAndEffect(CurrentWeapon.Hit());
            CurrentWeapon.Durabiblty -= 40;
            if (CurrentWeapon.Durabiblty <= 0) Console.WriteLine($"{CurrentWeapon.GetType().FullName} is broken!");
        }



        public override void Move()
        {
            Console.WriteLine("Warrior going to the barracs");
        }
    }
}
