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

            if (IsOpenWounds)
            {
                if (unit.Health - 2 > 0)
                {
                    unit.Health -= 2;
                    Console.WriteLine($"{unit.Type} received open wounds. Health - {unit.Health}");
                }
                else
                {
                    Console.WriteLine($"{unit.Type} is defeated");
                }

            }

            if (IsStunned)
            {
                Console.WriteLine("Can not attack. Stun.");
            }
            else
            {
                if (CurrentWeapon.GetType().Name == "BronzeMace")
                {
                    unit.Health -= CurrentWeapon.Damage;
                    Console.WriteLine(CurrentWeapon.Damage);
                    if (new Random().Next(0, 101) <= 20)
                    {
                        unit.IsStunned = true;
                        Console.WriteLine($"{unit.Type} stun!");
                    }
                    if (new Random().Next(0, 101) <= 10)
                    {
                        unit.IsOpenWounds = true;
                        Console.WriteLine($"{unit.Type} received open wounds.");
                    }
                }
                else
                {
                    unit.Health -= CurrentWeapon.Damage;
                }
            }

        }

        public override void Move()
        {
            Console.WriteLine("Warrior going to the barracs");
        }
    }
}
