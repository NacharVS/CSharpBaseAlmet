﻿using CSharpBaseAlmet.Weapons;
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
            if (CurrentWeapon != null)
            {
                anyUnit.GetDamageAndEffect(CurrentWeapon.Hit());
                if (CurrentWeapon.Durability > 0) 
                {
                    CurrentWeapon.Durability -= 10;
                }
                if (CurrentWeapon.Durability <= 0) 
                {
                    CurrentWeapon.Damage = 2;
                }
            }
            else
            {
                base.InflictDamage(anyUnit);
            }
        }

        public override void Move()
        {
            Console.WriteLine("Warrior going to the barracs");
        }
    }
}
