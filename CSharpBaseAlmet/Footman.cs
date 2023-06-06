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

        public void WeaponAttack(Unit unit)
        {
            unit.Health -= CurrentWeapon.Damage;
        }
    }
}
