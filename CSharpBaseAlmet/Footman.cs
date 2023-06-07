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
            if (CurrentWeapon != null && CurrentWeapon.Durability > 0) 
            {
                anyUnit.GetDamageAndEffect(CurrentWeapon.Hit());
                    CurrentWeapon.Durability = CurrentWeapon.Durability - 10;
                }
                else
                {
                    CurrentWeapon.Durability = 0;
                }
            }
            else
            {
                base.InflictDamage(anyUnit);
            }
        }
        //public void WeaponAttack(Unit unit)
        //{
        //    if (IsStunned)
        //    {
        //        Console.WriteLine($"Can't attacked");
        //    }
        //    else
        //    {

        //        if (CurrentWeapon.GetType().Name == "BronzeMace")
        //        {
        //            unit.Health -= CurrentWeapon.Hit().Item1;
        //            Console.WriteLine(CurrentWeapon.Damage);
        //            unit.IsStunned = CurrentWeapon.Hit().Item2;
        //        }
        //        else if (CurrentWeapon.GetType().Name == "StoneAxe")
        //        {
        //            if (new Random().Next(0, 101) <= 20)
        //            {
        //                unit.IsBleeding = true;
        //                Console.WriteLine($"{unit.Type} has bleending!");
        //            }
        //            if (IsBleeding)
        //            {
        //                unit.Health -= CurrentWeapon.Damage + 2;
        //                Console.WriteLine(CurrentWeapon.Damage + 2);
        //            }
        //            else
        //            {
        //                unit.Health -= CurrentWeapon.Damage;
        //                Console.WriteLine(CurrentWeapon.Damage);
        //            }

        //        }
        //        else
        //        {
        //            unit.Health -= CurrentWeapon.Damage;
        //        }

        //    }
        //}

        public override void Move()
        {
            Console.WriteLine("Warrior going to the barracs");
        }
    }
}
